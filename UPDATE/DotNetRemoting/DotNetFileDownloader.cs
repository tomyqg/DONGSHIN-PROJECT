// Decompiled with JetBrains decompiler
// Type: DotNetRemoting.DotNetFileDownloader
// Assembly: SmartQUpdate, Version=1.0.5948.29870, Culture=neutral, PublicKeyToken=null
// MVID: CB6247AF-5C4D-410C-BC45-5E423657901F
// Assembly location: C:\Users\YHW\Desktop\SmartQUpdate\SmartQUpdate.exe

using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace DotNetRemoting
{
  public class DotNetFileDownloader : IDisposable
  {
    private UseProxy _ProxyState = UseProxy.UseDefaultProxy;
    private int _TimeOut = 5000;
    private Control ParentFormRef;
    private bool ThreadStop;
    private string URL;
    private Thread fThread;
    private string OutFileName;
    private DStatus CurrStatus;
    private bool AbortFlag;
    private string _LocalFilePath;
    private string _UserName;
    private string _UserPassword;
    private string _Domain;
    private string _proxyUri;
    private bool _ByPassLocal;
    private System.Timers.Timer StopTimer;
    private System.Timers.Timer TimeoutTimer;
    private HttpWebRequest DNTWebRequest;
    private HttpWebResponse DNTWebResponse;
    private long FileLength;
    private long BytesCounter;
    private DateTime TimeStart;
    private FileStream fs;

    public int TimeOut
    {
      get
      {
        return this._TimeOut;
      }
      set
      {
        this._TimeOut = value;
      }
    }

    public string URLDownload
    {
      get
      {
        return this.URL;
      }
      set
      {
        this.URL = value;
      }
    }

    public UseProxy ProxyToUse
    {
      get
      {
        return this._ProxyState;
      }
      set
      {
        this._ProxyState = value;
      }
    }

    public string LocalFilePath
    {
      get
      {
        return this._LocalFilePath;
      }
      set
      {
        this._LocalFilePath = value;
      }
    }

    public event UpdateDelegate UpdateStatusEvent;

    public DotNetFileDownloader(Control formRef)
    {
      this.ParentFormRef = formRef;
      this.StopTimer = new System.Timers.Timer(500.0);
      this.StopTimer.Elapsed += new ElapsedEventHandler(this.StopTimer_Elapsed);
      this.TimeoutTimer = new System.Timers.Timer((double) this._TimeOut);
      this.TimeoutTimer.Elapsed += new ElapsedEventHandler(this.TimeoutTimer_Elapsed);
    }

    public void SetProxyInfo(string ProxyURI, string UserName, string Password, string Domain)
    {
      this.SetProxyInfo(ProxyURI, true, UserName, Password, Domain);
    }

    public void SetProxyInfo(string ProxyURI, bool BypassLocal, string UserName, string Password, string Domain)
    {
      if (this._ProxyState != UseProxy.UseProxy)
        throw new Exception("ProxyToUse property must be set to UseProxy first");
      this._UserName = UserName;
      this._UserPassword = Password;
      this._Domain = Domain;
      this._proxyUri = ProxyURI;
      this._ByPassLocal = BypassLocal;
    }

    public void Start()
    {
      this.ThreadStop = false;
      this.AbortFlag = false;
      this.fThread = new Thread(new ThreadStart(this.Worker_Thread_01));
      this.fThread.Priority = ThreadPriority.BelowNormal;
      this.fThread.IsBackground = true;
      this.fThread.Start();
      this.CurrStatus = DStatus.started;
      this.TimeoutTimer.Start();
    }

    public void Abort()
    {
      this.AbortFlag = true;
      this.ThreadStop = true;
      this.StopTimer.Start();
    }

    private void Worker_Thread_01()
    {
      this.HttpConnect(this.URL);
    }

    private void SendMessageToMainThread(string Message, DStatus Status, long FullSize, long CurrentBytes)
    {
      this.SendMessageToMainThread(Message, Status, FullSize, CurrentBytes, TimeSpan.Zero);
    }

    private void SendMessageToMainThread(string Message, DStatus Status, long FullSize, long CurrentBytes, TimeSpan TLeft)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (this.UpdateStatusEvent == null)
          return;
        object[] objArray = new object[5]{ (object) Message, (object) Status, (object) FullSize, (object) CurrentBytes, (object) TLeft };
        if (this.ParentFormRef != null)
        {
          // ISSUE: reference to a compiler-generated field
          this.ParentFormRef.Invoke((Delegate) this.UpdateStatusEvent, objArray);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.UpdateStatusEvent(Message, Status, FullSize, CurrentBytes, TLeft);
        }
      }
      catch
      {
      }
    }

    private TimeSpan CalcTimeLeft(DateTime start, long TotalItems, long CurrentItem)
    {
      if (CurrentItem == 0L)
        CurrentItem = 1L;
      TimeSpan timeSpan = DateTime.Now - start;
      return new TimeSpan((long) ((double) timeSpan.Ticks * ((double) TotalItems / (double) CurrentItem)) - timeSpan.Ticks);
    }

    private void HttpConnect(string Url)
    {
      WebProxy webProxy = (WebProxy) null;
      try
      {
        switch (this._ProxyState)
        {
          case UseProxy.UseDefaultProxy:
            webProxy = WebProxy.GetDefaultProxy();
            break;
          case UseProxy.UseProxy:
            webProxy = new WebProxy(this._proxyUri, this._ByPassLocal);
            webProxy.Credentials = (ICredentials) new NetworkCredential(this._UserName, this._UserPassword, this._Domain);
            break;
        }
        this.OutFileName = this._LocalFilePath;
        this.DNTWebRequest = (HttpWebRequest) WebRequest.Create(Url);
        this.DNTWebRequest.Proxy = (IWebProxy) webProxy;
        this.SendMessageToMainThread("trying to GetResponse()", DStatus.connecting, -1L, -1L, TimeSpan.Zero);
        this.DNTWebResponse = (HttpWebResponse) this.DNTWebRequest.GetResponse();
        this.SendMessageToMainThread("Response received", DStatus.connected, -1L, -1L, TimeSpan.Zero);
        this.fs = new FileStream(this.OutFileName, FileMode.OpenOrCreate, FileAccess.Write);
        this.FileLength = this.DNTWebResponse.ContentLength;
        if (this.FileLength == -1L)
          this.FileLength = 1L;
        string contentType = this.DNTWebResponse.ContentType;
        this.SendMessageToMainThread("Download started", DStatus.started, this.FileLength, 0L, TimeSpan.Zero);
        Stream responseStream = this.DNTWebResponse.GetResponseStream();
        this.TimeStart = DateTime.Now;
        int count1 = 10000;
        byte[] buffer = new byte[count1];
        while (!this.ThreadStop)
        {
          int count2 = responseStream.Read(buffer, 0, count1);
          switch (count2)
          {
            case -1:
            case 0:
              goto label_10;
            default:
              this.fs.Write(buffer, 0, count2);
              this.SendMessageToMainThread("Downloading OK ", this.CurrStatus, this.FileLength, this.BytesCounter, this.CalcTimeLeft(this.TimeStart, this.FileLength, this.BytesCounter));
              this.TimeoutTimer.Stop();
              this.TimeoutTimer.Start();
              this.BytesCounter = this.BytesCounter + (long) count2;
              this.CurrStatus = DStatus.downloading;
              continue;
          }
        }
label_10:
        this.fs.Flush();
        this.fs.Close();
      }
      catch (Exception ex)
      {
        this.CurrStatus = DStatus.failed;
        this.SendMessageToMainThread(ex.Message, this.CurrStatus, this.FileLength, this.BytesCounter);
        this.TimeoutTimer.Stop();
        return;
      }
      if (this.AbortFlag)
      {
        this.CurrStatus = DStatus.aborted;
        this.SendMessageToMainThread("download aborted", this.CurrStatus, this.FileLength, this.BytesCounter);
      }
      else
      {
        this.CurrStatus = DStatus.complete;
        this.SendMessageToMainThread(this.OutFileName, this.CurrStatus, this.FileLength, this.BytesCounter);
      }
      this.TimeoutTimer.Stop();
    }

    public void Dispose()
    {
      try
      {
        this.fs.Close();
      }
      catch
      {
      }
      try
      {
        this.StopTimer.Dispose();
        this.TimeoutTimer.Stop();
        this.TimeoutTimer.Dispose();
        this.DNTWebResponse.Close();
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.ThreadStop = true;
        Thread.Sleep(500);
        this.fThread.Abort();
      }
      catch
      {
      }
    }

    private void StopTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
      this.StopTimer.Stop();
      try
      {
        try
        {
          this.fs.Close();
        }
        catch
        {
        }
        this.fThread.Abort();
        this.DNTWebResponse.Close();
        this.SendMessageToMainThread("download aborted", this.CurrStatus, this.FileLength, this.BytesCounter);
      }
      catch
      {
        this.SendMessageToMainThread("download aborted", this.CurrStatus, this.FileLength, this.BytesCounter);
      }
    }

    private void TimeoutTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
      try
      {
        try
        {
          this.fs.Close();
        }
        catch
        {
        }
        this.StopTimer.Stop();
        this.TimeoutTimer.Stop();
        this.AbortFlag = true;
        this.ThreadStop = true;
        Thread.Sleep(200);
        this.CurrStatus = DStatus.failed;
        this.SendMessageToMainThread("Timeout", this.CurrStatus, this.FileLength, this.BytesCounter);
        this.fThread.Abort();
      }
      catch
      {
      }
    }
  }
}
