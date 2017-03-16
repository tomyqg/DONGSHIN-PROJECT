using DotNetRemoting;
using FileDownloaderApp;
using SmartQUpdate.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;
using System.Net.NetworkInformation;

namespace SmartQUpdate
{
  public partial class AutoUpdate : Form
  {
    private FileDownloader downloader = new FileDownloader();
    private DotNetFileDownloader _FileDownloader;
    private string _executeFile;
    private string downloadToPath;
    private string _localVersion;
    private string _remoteVersion;
    private IContainer components;
    private System.Windows.Forms.Timer timer1;
    private Label label_status;
    private Label label_curr_bytes;
    private System.Windows.Forms.Timer timer2;
    private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;


    public delegate void ProgressEvent(long progress);
    public event ProgressEvent Unzipping;
    string lang = "EUC-KR";

    public AutoUpdate()
    {
      this.InitializeComponent();
    }

    private void CompareVersions()
    {
        try
        {
            this.label_status.Text = "프로그램 version 확인중입니다.";
            UPDATE.Version.CompareVersions(out this._localVersion, out this._remoteVersion);
        }catch{
            throw;
        }
      
    }

    private void BeginDownload(string remoteURL, string downloadToPath, string version, string fileName)
    {
      UPDATE.Version.CreateTargetLocation(downloadToPath, version);
      try
      {
        Uri uri = new Uri(remoteURL);
        WebClient webClient = new WebClient();
        AsyncCompletedEventHandler completedEventHandler = new AsyncCompletedEventHandler(this.downloader_DownloadFileCompleted);
        webClient.DownloadFileCompleted += completedEventHandler;
        Uri address = uri;
        string fileName1 = fileName;
        string[] strArray = new string[3]{ version, downloadToPath, fileName };
        webClient.DownloadFileAsync(address, fileName1, (object) strArray);
      }
      catch
      {
      }
    }

    private void _FileDownloader_UpdateStatusEvent(string Message, DStatus Status, long FullSize, long CurrentBytes, TimeSpan EstimatedTimeLeft)
    {
      this.label_status.Text = Message + "\n" + Status.ToString();
      if (FullSize != 0L && FullSize != -1L)
      {
          this.progressBarControl1.EditValue = (int)((double)CurrentBytes / (double)FullSize * 100.0);
          
        this.label_curr_bytes.Text = CurrentBytes.ToString() + " Kb of " + FullSize.ToString() + " Kb";
      }
      if (Status != DStatus.complete && Status != DStatus.failed)
        ;
      if (EstimatedTimeLeft.TotalMilliseconds <= 0.0)
        return;
      string str = EstimatedTimeLeft.ToString();
      str.Substring(0, str.IndexOf('.'));
    }

    private void downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
    {
      string[] userState = (string[]) e.UserState;
      int index1 = 0;
      string str1 = userState[index1];
      int index2 = 1;
      string str2 = userState[index2];
      int index3 = 2;
      string str3 = userState[index3];
      if (!str2.EndsWith("\\"))
        str2 += "\\";
      string zipName = str2 + str3;
      string str4 = str2 + "\\" + str3;
      this.ZipExtract(zipName);
    }

    private bool ZipExtract(string zipName)
    {
      bool flag;
      try
      {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        string str1 = this.downloadToPath + "7z.exe";
        startInfo.FileName = str1;
        string str2 = "x -y " + zipName;
        startInfo.Arguments = str2;
        Process process = Process.Start(startInfo);
        process.WaitForExit();
        flag = true;
        process.Dispose();
      }
      catch (Exception ex)
      {
        flag = false;
      }
      return flag;
    }

    private bool UnZip(string zipName)
    {
      return true;
    }

    private void downloader_CalculationFileSize(object sender, int fileNr)
    {
      this.label_status.Text = string.Format("Calculating file sizes - file {0} of {1}", (object) fileNr, (object) this.downloader.Files.Count);
    }

    private void downloader_ProgressChanged(object sender, EventArgs e)
    {
      if ((int) this.downloader.CurrentFilePercentage() > 0 && (int) this.downloader.CurrentFilePercentage() < 100)
          this.progressBarControl1.EditValue = (int)this.downloader.CurrentFilePercentage();
      this.label_curr_bytes.Text = string.Format("Downloaded {0} of {1} ({2}%)", (object) FileDownloader.FormatSizeBinary(this.downloader.CurrentFileProgress), (object) FileDownloader.FormatSizeBinary(this.downloader.CurrentFileSize), (object) this.downloader.CurrentFilePercentage()) + string.Format(" - {0}/s", (object) FileDownloader.FormatSizeBinary((long) this.downloader.DownloadSpeed));
      if (!this.downloader.SupportsProgress)
        return;
      this.progressBarControl1.EditValue = (int)this.downloader.TotalPercentage();
      this.label_curr_bytes.Text = string.Format("Downloaded {0} of {1} ({2}%)", (object) FileDownloader.FormatSizeBinary(this.downloader.TotalProgress), (object) FileDownloader.FormatSizeBinary(this.downloader.TotalSize), (object) this.downloader.TotalPercentage());
    }

    private void downloader_FileDownloadAttempting(object sender, EventArgs e)
    {
      this.label_status.Text = string.Format("Preparing {0}", (object) this.downloader.CurrentFile.Name);
    }

    private void downloader_FileDownloadStarted(object sender, EventArgs e)
    {
      this.label_status.Text = string.Format("Downloading {0}", (object) this.downloader.CurrentFile.Name);
    }

    private void downloader_Completed(object sender, EventArgs e)
    {
        this.progressBarControl1.EditValue = 100;
      this.label_status.Text = string.Format("Download complete, downloaded {0} files.", (object) this.downloader.Files.Count);
      this.Refresh();
      this.timer2.Interval = 1000;
      this.timer2.Enabled = true;
    }

    private void downloader_CancelRequested(object sender, EventArgs e)
    {
      this.label_status.Text = "Canceling downloads...";
    }

    private void downloader_DeletingFilesAfterCancel(object sender, EventArgs e)
    {
      this.label_status.Text = "Canceling downloads - deleting files...";
    }

    private void downloader_Canceled(object sender, EventArgs e)
    {
      this.label_status.Text = "Download(s) canceled";
      this.progressBarControl1.EditValue = 0;
    }

    private void UpdateStart() 
    {
        this.downloader.CalculatingFileSize += new FileDownloader.CalculatingFileSizeEventHandler(this.downloader_CalculationFileSize);
        this.downloader.ProgressChanged += new EventHandler(this.downloader_ProgressChanged);
        this.downloader.FileDownloadAttempting += new EventHandler(this.downloader_FileDownloadAttempting);
        this.downloader.FileDownloadStarted += new EventHandler(this.downloader_FileDownloadStarted);
        this.downloader.Completed += new EventHandler(this.downloader_Completed);
        this.downloader.CancelRequested += new EventHandler(this.downloader_CancelRequested);
        this.downloader.DeletingFilesAfterCancel += new EventHandler(this.downloader_DeletingFilesAfterCancel);
        this.downloader.Canceled += new EventHandler(this.downloader_Canceled);

        try
        {
            CheckForInternetConnection();

            this.CompareVersions();

            Thread.Sleep(300);
            this.downloadToPath = Application.StartupPath;
            if (this._localVersion != this._remoteVersion)
            {
                this.downloader.LocalDirectory = this.downloadToPath;
                this.downloader.Files.Clear();
                for (int index = 0; index < UPDATE.Version._DownloadFile.Length; ++index)
                    this.downloader.Files.Add(new FileDownloader.FileInfo(UPDATE.Version._remoteURL + UPDATE.Version._DownloadFile[index]));

                downloader.Files.Add(new FileDownloader.FileInfo(UPDATE.Version._remoteURL + "AppInfo.xml"));
                this.downloader.Start();
            }
            else
                UpdateStop();
        }
        catch(Exception ex)
        {
            string title = "문제가 발생하여 종료합니다\n";

            MessageBox.Show(ex.Message, title);
            this.Close();
        }
        
    }
      
    private void UpdateStop() 
    {
        try
        {
            try
            {
                this.downloader.Stop();
            }
            catch
            {
            }
            this.label_status.Text = "프로그램 적용중입니다.";
            this.label_status.Refresh();
            if ( !this.downloadToPath.EndsWith("\\") )
                this.downloadToPath = this.downloadToPath + "\\";
            bool flag = false;
            for ( int index = 0 ; index < this.downloader.Files.Count ; ++index )
            {
                this.label_status.Text = "프로그램 적용중입니다.(" + (object)(index + 1) + "/" + (object)this.downloader.Files.Count + ")";
                this.label_status.Refresh();
                string str = this.downloadToPath + this.downloader.Files[index].Name;
                if ( str.Contains(".zip") )
                {
                    using ( ZipFile zip = ZipFile.Read(str) )
                    {
                        /// Unzipping 될때 이벤트 핸들러를 등록 (현재 진행 상황을 위해)
                        zip.ReadProgress += new EventHandler<ReadProgressEventArgs>(zip_ReadProgress);

                        /// Unzipping
                        zip.ExtractAll(downloadToPath, true);

                        flag = true;
                    }

                    //flag = this.ZipExtract(str);
                    Thread.Sleep(500);
                    if ( flag )
                        System.IO.File.Delete(str);
                }
            }

        }
        catch ( Exception ex )
        {
            MessageBox.Show(ex.Message);
        }
        this.Close();
        try
        {
            //this._executeFile = UPDATE.Version._ExecuteFile;
            //if ( !(this._executeFile != "") || !new System.IO.FileInfo(this._executeFile).Exists )
            //    return;

            //Process.Start(this._executeFile).WaitForExit(500);
            this._executeFile = Application.StartupPath+"\\" + UPDATE.Version._ExecuteFile;

            if ( !(this._executeFile != "") || !new System.IO.FileInfo(this._executeFile).Exists )
                return;

            Process.Start(this._executeFile).WaitForExit(500);
        }
        catch
        {
        }
    }

    private void zip_ReadProgress(object sender, ReadProgressEventArgs e)
    {
        if (Unzipping != null)
        {
            Unzipping((long)((double)e.BytesTransferred / ((double)e.TotalBytesToTransfer + 1) * 100));
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        this.timer1.Enabled = false;
        this.timer2.Enabled = false;
        UpdateStart();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
        this.timer2.Enabled = false;
        UpdateStop();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.label_status.Text = "프로그램 version 확인중입니다.";
      this.Refresh();
      this.timer1.Interval = 1000;
      this.timer1.Enabled = true;
      this.timer2.Enabled = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoUpdate));
            this.timer1 = new System.Windows.Forms.Timer();
            this.label_status = new System.Windows.Forms.Label();
            this.label_curr_bytes = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_status
            // 
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_status.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_status.Location = new System.Drawing.Point(653, 807);
            this.label_status.Margin = new System.Windows.Forms.Padding(3);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(580, 29);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "version";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_curr_bytes
            // 
            this.label_curr_bytes.BackColor = System.Drawing.Color.Transparent;
            this.label_curr_bytes.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_curr_bytes.ForeColor = System.Drawing.Color.White;
            this.label_curr_bytes.Location = new System.Drawing.Point(653, 868);
            this.label_curr_bytes.Margin = new System.Windows.Forms.Padding(3);
            this.label_curr_bytes.Name = "label_curr_bytes";
            this.label_curr_bytes.Size = new System.Drawing.Size(580, 18);
            this.label_curr_bytes.TabIndex = 5;
            this.label_curr_bytes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(653, 842);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.progressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.progressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarControl1.Properties.PercentView = false;
            this.progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progressBarControl1.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.progressBarControl1.Size = new System.Drawing.Size(580, 20);
            this.progressBarControl1.TabIndex = 25;
            // 
            // AutoUpdate
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.label_curr_bytes);
            this.Controls.Add(this.label_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoUpdate";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONGSHIN UPDATE";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

    }

    public bool CheckForInternetConnection()
    {
        //네트웍 연결확인
        bool connection = NetworkInterface.GetIsNetworkAvailable();

        if (connection == true)
        {
            try
            {
                //인터넷 연결확인
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                throw new Exception("Not Connected To INTERNET");
            }
        }
        else
            throw new Exception("Not Connected To Network");

    }

  }
}
