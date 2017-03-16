// Decompiled with JetBrains decompiler
// Type: FileDownloaderApp.FileDownloader
// Assembly: SmartQUpdate, Version=1.0.5948.29870, Culture=neutral, PublicKeyToken=null
// MVID: CB6247AF-5C4D-410C-BC45-5E423657901F
// Assembly location: C:\Users\YHW\Desktop\SmartQUpdate\SmartQUpdate.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace FileDownloaderApp
{
  internal class FileDownloader : IDisposable
  {
    private BackgroundWorker bgwDownloader = new BackgroundWorker();
    private List<FileDownloader.FileInfo> m_files = new List<FileDownloader.FileInfo>();
    private const int default_decimals = 2;
    private bool m_supportsProgress;
    private bool m_deleteCompletedFiles;
    private int m_packageSize;
    private int m_stopWatchCycles;
    private bool m_disposed;
    private bool m_busy;
    private bool m_paused;
    private bool m_canceled;
    private long m_currentFileProgress;
    private long m_totalProgress;
    private long m_currentFileSize;
    private int m_currentSpeed;
    private int m_fileNr;
    private string m_localDirectory;
    private long m_totalSize;

    public List<FileDownloader.FileInfo> Files
    {
      get
      {
        return this.m_files;
      }
      set
      {
        if (this.IsBusy)
          throw new InvalidOperationException("You can not change the file list during the download");
        if (this.Files == null)
          return;
        this.m_files = value;
      }
    }

    public string LocalDirectory
    {
      get
      {
        return this.m_localDirectory;
      }
      set
      {
        if (!(this.LocalDirectory != value))
          return;
        this.m_localDirectory = value;
      }
    }

    public bool SupportsProgress
    {
      get
      {
        return this.m_supportsProgress;
      }
      set
      {
        if (this.IsBusy)
          throw new InvalidOperationException("You can not change the SupportsProgress property during the download");
        this.m_supportsProgress = value;
      }
    }

    public bool DeleteCompletedFilesAfterCancel
    {
      get
      {
        return this.m_deleteCompletedFiles;
      }
      set
      {
        this.m_deleteCompletedFiles = value;
      }
    }

    public int PackageSize
    {
      get
      {
        return this.m_packageSize;
      }
      set
      {
        if (value <= 0)
          throw new InvalidOperationException("The PackageSize needs to be greather then 0");
        this.m_packageSize = value;
      }
    }

    public int StopWatchCyclesAmount
    {
      get
      {
        return this.m_stopWatchCycles;
      }
      set
      {
        if (value <= 0)
          throw new InvalidOperationException("The StopWatchCyclesAmount needs to be greather then 0");
        this.m_stopWatchCycles = value;
      }
    }

    public bool IsBusy
    {
      get
      {
        return this.m_busy;
      }
      set
      {
        if (this.IsBusy == value)
          return;
        this.m_busy = value;
        this.m_canceled = !value;
        if (this.IsBusy)
        {
          this.m_totalProgress = 0L;
          this.bgwDownloader.RunWorkerAsync();
          if (this.Started != null)
            this.Started((object) this, new EventArgs());
          if (this.IsBusyChanged != null)
            this.IsBusyChanged((object) this, new EventArgs());
          if (this.StateChanged == null)
            return;
          this.StateChanged((object) this, new EventArgs());
        }
        else
        {
          this.m_paused = false;
          this.bgwDownloader.CancelAsync();
          if (this.CancelRequested != null)
            this.CancelRequested((object) this, new EventArgs());
          if (this.StateChanged == null)
            return;
          this.StateChanged((object) this, new EventArgs());
        }
      }
    }

    public bool IsPaused
    {
      get
      {
        return this.m_paused;
      }
      set
      {
        if (!this.IsBusy)
          throw new InvalidOperationException("You can not change the IsPaused property when the FileDownloader is not busy");
        if (this.IsPaused == value)
          return;
        this.m_paused = value;
        if (this.IsPaused)
        {
          if (this.Paused != null)
            this.Paused((object) this, new EventArgs());
        }
        else if (this.Resumed != null)
          this.Resumed((object) this, new EventArgs());
        if (this.IsPausedChanged != null)
          this.IsPausedChanged((object) this, new EventArgs());
        if (this.StateChanged == null)
          return;
        this.StateChanged((object) this, new EventArgs());
      }
    }

    public bool CanStart
    {
      get
      {
        return !this.IsBusy;
      }
    }

    public bool CanPause
    {
      get
      {
        if (this.IsBusy && !this.IsPaused)
          return !this.bgwDownloader.CancellationPending;
        return false;
      }
    }

    public bool CanResume
    {
      get
      {
        if (this.IsBusy && this.IsPaused)
          return !this.bgwDownloader.CancellationPending;
        return false;
      }
    }

    public bool CanStop
    {
      get
      {
        if (this.IsBusy)
          return !this.bgwDownloader.CancellationPending;
        return false;
      }
    }

    public long TotalSize
    {
      get
      {
        if (this.SupportsProgress)
          return this.m_totalSize;
        throw new InvalidOperationException("This FileDownloader that it doesn't support progress. Modify SupportsProgress to state that it does support progress to get the total size.");
      }
    }

    public long TotalProgress
    {
      get
      {
        return this.m_totalProgress;
      }
    }

    public long CurrentFileProgress
    {
      get
      {
        return this.m_currentFileProgress;
      }
    }

    public int DownloadSpeed
    {
      get
      {
        return this.m_currentSpeed;
      }
    }

    public FileDownloader.FileInfo CurrentFile
    {
      get
      {
        return this.Files[this.m_fileNr];
      }
    }

    public long CurrentFileSize
    {
      get
      {
        return this.m_currentFileSize;
      }
    }

    public bool HasBeenCanceled
    {
      get
      {
        return this.m_canceled;
      }
    }

    public event EventHandler Started;

    public event EventHandler Paused;

    public event EventHandler Resumed;

    public event EventHandler CancelRequested;

    public event EventHandler DeletingFilesAfterCancel;

    public event EventHandler Canceled;

    public event EventHandler Completed;

    public event EventHandler Stopped;

    public event EventHandler IsBusyChanged;

    public event EventHandler IsPausedChanged;

    public event EventHandler StateChanged;

    public event EventHandler CalculationFileSizesStarted;

    public event FileDownloader.CalculatingFileSizeEventHandler CalculatingFileSize;

    public event EventHandler FileSizesCalculationComplete;

    public event EventHandler FileDownloadAttempting;

    public event EventHandler FileDownloadStarted;

    public event EventHandler FileDownloadStopped;

    public event EventHandler FileDownloadSucceeded;

    public event FileDownloader.FailEventHandler FileDownloadFailed;

    public event EventHandler ProgressChanged;

    public FileDownloader()
    {
      this.initizalize(false);
    }

    public FileDownloader(bool supportsProgress)
    {
      this.initizalize(supportsProgress);
    }

    private void initizalize(bool supportsProgress)
    {
      this.bgwDownloader.WorkerReportsProgress = true;
      this.bgwDownloader.WorkerSupportsCancellation = true;
      this.bgwDownloader.DoWork += new DoWorkEventHandler(this.bgwDownloader_DoWork);
      this.bgwDownloader.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwDownloader_RunWorkerCompleted);
      this.bgwDownloader.ProgressChanged += new ProgressChangedEventHandler(this.bgwDownloader_ProgressChanged);
      this.SupportsProgress = supportsProgress;
      this.PackageSize = 4096;
      this.StopWatchCyclesAmount = 5;
      this.DeleteCompletedFilesAfterCancel = true;
    }

    public void Start()
    {
      this.IsBusy = true;
    }

    public void Pause()
    {
      this.IsPaused = true;
    }

    public void Resume()
    {
      this.IsPaused = false;
    }

    public void Stop()
    {
      this.IsBusy = false;
    }

    public void Stop(bool deleteCompletedFiles)
    {
      this.DeleteCompletedFilesAfterCancel = deleteCompletedFiles;
      this.Stop();
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public static string FormatSizeBinary(long size)
    {
      return FileDownloader.FormatSizeBinary(size, 2);
    }

    public static string FormatSizeBinary(long size, int decimals)
    {
      string[] strArray = new string[9]{ "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
      double num = (double) size;
      int index;
      for (index = 0; num >= 1024.0 && index < strArray.Length; ++index)
        num /= 1024.0;
      return Math.Round(num, decimals).ToString() + strArray[index];
    }

    public static string FormatSizeDecimal(long size)
    {
      return FileDownloader.FormatSizeDecimal(size, 2);
    }

    public static string FormatSizeDecimal(long size, int decimals)
    {
      string[] strArray = new string[9]{ "B", "kB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
      double num = (double) size;
      int index;
      for (index = 0; num >= 1000.0 && index < strArray.Length; ++index)
        num /= 1000.0;
      return Math.Round(num, decimals).ToString() + strArray[index];
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.m_disposed)
        return;
      if (disposing)
        this.bgwDownloader.Dispose();
      this.Files = (List<FileDownloader.FileInfo>) null;
    }

    private void bgwDownloader_DoWork(object sender, DoWorkEventArgs e)
    {
      int fileNr = 0;
      if (this.SupportsProgress)
        this.calculateFilesSize();
      if (!Directory.Exists(this.LocalDirectory))
        Directory.CreateDirectory(this.LocalDirectory);
      while (fileNr < this.Files.Count && !this.bgwDownloader.CancellationPending)
      {
        this.m_fileNr = fileNr;
        this.downloadFile(fileNr);
        if (this.bgwDownloader.CancellationPending)
        {
          this.fireEventFromBgw(FileDownloader.Event.DeletingFilesAfterCancel);
          this.cleanUpFiles(this.DeleteCompletedFilesAfterCancel ? 0 : this.m_fileNr, this.DeleteCompletedFilesAfterCancel ? this.m_fileNr + 1 : 1);
        }
        else
          ++fileNr;
      }
    }

    private void calculateFilesSize()
    {
      this.fireEventFromBgw(FileDownloader.Event.CalculationFileSizesStarted);
      this.m_totalSize = 0L;
      for (int index = 0; index < this.Files.Count; ++index)
      {
        this.bgwDownloader.ReportProgress(2, (object) (index + 1));
        try
        {
          HttpWebResponse response = (HttpWebResponse) WebRequest.Create(this.Files[index].Path).GetResponse();
          this.m_totalSize = this.m_totalSize + response.ContentLength;
          response.Close();
        }
        catch (Exception ex)
        {
        }
      }
      this.fireEventFromBgw(FileDownloader.Event.FileSizesCalculationComplete);
    }

    private void fireEventFromBgw(FileDownloader.Event eventName)
    {
      this.bgwDownloader.ReportProgress(0, (object) eventName);
    }

    private void downloadFile(int fileNr)
    {
      this.m_currentFileSize = 0L;
      FileDownloader.FileInfo file = this.Files[fileNr];
      if (file.Name.Contains("7z.exe") && new System.IO.FileInfo(this.LocalDirectory + "\\" + file.Name).Exists)
        return;
      this.fireEventFromBgw(FileDownloader.Event.FileDownloadAttempting);
      long num1 = 0;
      byte[] buffer = new byte[this.PackageSize];
      Stopwatch stopwatch = new Stopwatch();
      int num2 = 0;
      Exception exception = (Exception) null;
      FileStream fileStream = new FileStream(this.LocalDirectory + "\\" + file.Name, FileMode.Create);
      HttpWebResponse httpWebResponse = (HttpWebResponse) null;
      try
      {
        httpWebResponse = (HttpWebResponse) WebRequest.Create(this.Files[fileNr].Path).GetResponse();
        num1 = httpWebResponse.ContentLength;
      }
      catch (Exception ex)
      {
        exception = ex;
      }
      this.m_currentFileSize = num1;
      this.fireEventFromBgw(FileDownloader.Event.FileDownloadStarted);
      if (exception != null)
      {
        this.bgwDownloader.ReportProgress(1, (object) exception);
      }
      else
      {
        this.m_currentFileProgress = 0L;
        while (this.m_currentFileProgress < num1 && !this.bgwDownloader.CancellationPending)
        {
          while (this.IsPaused)
            Thread.Sleep(100);
          stopwatch.Start();
          int count = httpWebResponse.GetResponseStream().Read(buffer, 0, this.PackageSize);
          this.m_currentFileProgress = this.m_currentFileProgress + (long) count;
          this.m_totalProgress = this.m_totalProgress + (long) count;
          this.fireEventFromBgw(FileDownloader.Event.ProgressChanged);
          fileStream.Write(buffer, 0, count);
          ++num2;
          if (num2 >= this.StopWatchCyclesAmount)
          {
            this.m_currentSpeed = (int) ((long) (this.PackageSize * this.StopWatchCyclesAmount * 1000) / (stopwatch.ElapsedMilliseconds + 1L));
            stopwatch.Reset();
            num2 = 0;
          }
        }
        stopwatch.Stop();
        fileStream.Close();
        httpWebResponse.Close();
        if (!this.bgwDownloader.CancellationPending)
          this.fireEventFromBgw(FileDownloader.Event.FileDownloadSucceeded);
      }
      this.fireEventFromBgw(FileDownloader.Event.FileDownloadStopped);
    }

    private void cleanUpFiles(int start, int length)
    {
      int num = length < 0 ? this.Files.Count - 1 : start + length - 1;
      for (int index = start; index <= num; ++index)
      {
        string path = this.LocalDirectory + "\\" + this.Files[index].Name;
        if (System.IO.File.Exists(path))
          System.IO.File.Delete(path);
      }
    }

    private void bgwDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.m_paused = false;
      this.m_busy = false;
      if (this.HasBeenCanceled)
      {
        // ISSUE: reference to a compiler-generated field
        if (this.Canceled != null)
        {
          // ISSUE: reference to a compiler-generated field
          this.Canceled((object) this, new EventArgs());
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (this.Completed != null)
        {
          // ISSUE: reference to a compiler-generated field
          this.Completed((object) this, new EventArgs());
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (this.Stopped != null)
      {
        // ISSUE: reference to a compiler-generated field
        this.Stopped((object) this, new EventArgs());
      }
      // ISSUE: reference to a compiler-generated field
      if (this.IsBusyChanged != null)
      {
        // ISSUE: reference to a compiler-generated field
        this.IsBusyChanged((object) this, new EventArgs());
      }
      // ISSUE: reference to a compiler-generated field
      if (this.StateChanged == null)
        return;
      // ISSUE: reference to a compiler-generated field
      this.StateChanged((object) this, new EventArgs());
    }

    private void bgwDownloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      switch (e.ProgressPercentage)
      {
        case 0:
          switch ((FileDownloader.Event) e.UserState)
          {
            case FileDownloader.Event.CalculationFileSizesStarted:
              // ISSUE: reference to a compiler-generated field
              if (this.CalculationFileSizesStarted == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.CalculationFileSizesStarted((object) this, new EventArgs());
              return;
            case FileDownloader.Event.FileSizesCalculationComplete:
              // ISSUE: reference to a compiler-generated field
              if (this.FileSizesCalculationComplete == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.FileSizesCalculationComplete((object) this, new EventArgs());
              return;
            case FileDownloader.Event.DeletingFilesAfterCancel:
              // ISSUE: reference to a compiler-generated field
              if (this.DeletingFilesAfterCancel == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.DeletingFilesAfterCancel((object) this, new EventArgs());
              return;
            case FileDownloader.Event.FileDownloadAttempting:
              // ISSUE: reference to a compiler-generated field
              if (this.FileDownloadAttempting == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.FileDownloadAttempting((object) this, new EventArgs());
              return;
            case FileDownloader.Event.FileDownloadStarted:
              // ISSUE: reference to a compiler-generated field
              if (this.FileDownloadStarted == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.FileDownloadStarted((object) this, new EventArgs());
              return;
            case FileDownloader.Event.FileDownloadStopped:
              // ISSUE: reference to a compiler-generated field
              if (this.FileDownloadStopped == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.FileDownloadStopped((object) this, new EventArgs());
              return;
            case FileDownloader.Event.FileDownloadSucceeded:
              // ISSUE: reference to a compiler-generated field
              if (this.FileDownloadSucceeded == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.FileDownloadSucceeded((object) this, new EventArgs());
              return;
            case FileDownloader.Event.ProgressChanged:
              // ISSUE: reference to a compiler-generated field
              if (this.ProgressChanged == null)
                return;
              // ISSUE: reference to a compiler-generated field
              this.ProgressChanged((object) this, new EventArgs());
              return;
            default:
              return;
          }
        case 1:
          // ISSUE: reference to a compiler-generated field
          if (this.FileDownloadFailed == null)
            break;
          // ISSUE: reference to a compiler-generated field
          this.FileDownloadFailed((object) this, (Exception) e.UserState);
          break;
        case 2:
          // ISSUE: reference to a compiler-generated field
          if (this.CalculatingFileSize == null)
            break;
          // ISSUE: reference to a compiler-generated field
          this.CalculatingFileSize((object) this, (int) e.UserState);
          break;
      }
    }

    public double TotalPercentage()
    {
      return this.TotalPercentage(2);
    }

    public double TotalPercentage(int decimals)
    {
      if (this.SupportsProgress)
        return Math.Round((double) this.TotalProgress / (double) this.TotalSize * 100.0, decimals);
      throw new InvalidOperationException("This FileDownloader that it doesn't support progress. Modify SupportsProgress to state that it does support progress.");
    }

    public double CurrentFilePercentage()
    {
      return this.CurrentFilePercentage(2);
    }

    public double CurrentFilePercentage(int decimals)
    {
      return Math.Round((double) this.CurrentFileProgress / (double) this.CurrentFileSize * 100.0, decimals);
    }

    public struct FileInfo
    {
      public string Path;
      public string Name;

      public FileInfo(string path)
      {
        this.Path = path;
        this.Name = this.Path.Split("/"[0])[this.Path.Split("/"[0]).Length - 1];
      }
    }

    private enum Event
    {
      CalculationFileSizesStarted,
      FileSizesCalculationComplete,
      DeletingFilesAfterCancel,
      FileDownloadAttempting,
      FileDownloadStarted,
      FileDownloadStopped,
      FileDownloadSucceeded,
      ProgressChanged,
    }

    private enum InvokeType
    {
      EventRaiser,
      FileDownloadFailedRaiser,
      CalculatingFileNrRaiser,
    }

    public delegate void FailEventHandler(object sender, Exception ex);

    public delegate void CalculatingFileSizeEventHandler(object sender, int fileNr);
  }
}
