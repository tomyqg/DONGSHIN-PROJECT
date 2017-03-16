using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace DONGSHIN
{
   public class imgUploadHelper
    {

         #region 멤버 변수 & 프로퍼티
 
        /// <summary>
        ///
        /// </summary>
        private string host;
 
        /// <summary>
        /// FTP 서버 호스트명(IP)를 가져옵니다.
        /// </summary>
        public string Host
        {
            get { return host; }
            private set { host = value; }
        }
 
        private string userName;
 
        /// <summary>
        /// 사용자 명을 가져옵니다.
        /// </summary>
        public string UserName
        {
            get { return userName; }
            private set { userName = value; }
        }
 
        private string password;
 
        /// <summary>
        /// 비밀번호를 가져옵니다.
        /// </summary>
        public string Password
        {
            get { return password; }
            private set { password = value; }
        }


        
        #endregion
 
    #region 생성자
 
    /// <summary>
    /// 새 인스턴스를 생성합니다.
    /// </summary>
    /// <param name="host">FTP 서버 주소 입니다.</param>
    /// <param name="userName">FTP 사용자 아이디 입니다.</param>
    /// <param name="password">FTP 비밀번호 입니다.</param>
    public imgUploadHelper(string host, string userName, string password)
    {
        this.Host = host;
        this.UserName = userName;
        this.Password = password;
    }
 
    #endregion

        #region 메서드

        /// <summary>
        /// 파일을 FTP 서버에 업로드 합니다.
        /// </summary>
        /// <param name="localFileFullPath">로컬 파일의 전체 경로 입니다.</param>
        /// <param name="ftpFilePath"><para>파일을 업로드 할 FTP 전체 경로 입니다.</para><para>하위 디렉터리에 넣는 경우 /디렉터리명/파일명.확장자 형태 입니다.</para></param>
        /// <exception cref="FileNotFoundException">지정한 로컬 파일(localFileFullPath)이 없을 때 발생합니다.</exception>
        /// <returns>업로드 성공 여부입니다.</returns>
        public bool Upload(string localFileFullPath, string ftpFilePath)
        {
            LocalFileValidationCheck(localFileFullPath);

            FTPDirectioryCheck(GetDirectoryPath(ftpFilePath));
            if ( IsFTPFileExsit(ftpFilePath) )
            {
                return true;        
                throw new ApplicationException(string.Format("{0}은 이미 존재하는 파일 입니다.", ftpFilePath));                
            }
            string ftpFileFullPath = string.Format("{0}/{1}", this.Host, ftpFilePath);
            FtpWebRequest ftpWebRequest = WebRequest.Create(new Uri(ftpFileFullPath)) as FtpWebRequest;
            ftpWebRequest.Credentials = GetCredentials();
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.UsePassive = true;
            ftpWebRequest.Timeout = 10000;
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;

            FileInfo fileInfo = new FileInfo(localFileFullPath);
            FileStream fileStream = fileInfo.OpenRead();
            Stream stream = null;
            byte[] buf = new byte[2048];
            int currentOffset = 0;
            try
            {
                stream = ftpWebRequest.GetRequestStream();
                currentOffset = fileStream.Read(buf, 0, 2048);
                while ( currentOffset != 0 )
                {
                    stream.Write(buf, 0, currentOffset);
                    currentOffset = fileStream.Read(buf, 0, 2048);
                }

            }
            finally
            {
                fileStream.Dispose();
                if ( stream != null )
                    stream.Dispose();
            }

            return true;
        }

        /// <summary>
        /// 해당 경로에 파일이 존재하는지 여부를 가져옵니다.
        /// </summary>
        /// <param name="ftpFilePath">파일 경로</param>
        /// <returns>존재시 참 </returns>
        private bool IsFTPFileExsit(string ftpFilePath)
        {
            string fileName = GetFileName(ftpFilePath);
            string ftpFileFullPath = string.Format("{0}/{1}", this.Host, GetDirectoryPath(ftpFilePath));
            FtpWebRequest ftpWebRequest = WebRequest.Create(new Uri(ftpFileFullPath)) as FtpWebRequest;
            ftpWebRequest.Credentials = new NetworkCredential(this.UserName, this.Password);
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.UsePassive = true;
            ftpWebRequest.Timeout = 10000;
            ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = null;
            string data = string.Empty;
            try
            {
                response = ftpWebRequest.GetResponse() as FtpWebResponse;
                if ( response != null )
                {
                    StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.Default);
                    data = streamReader.ReadToEnd();
                }
            }
            finally
            {
                if ( response != null )
                {
                    response.Close();
                }
            }

            string[] directorys = data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return (from directory in directorys
                    select directory.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        into directoryInfos
                        where directoryInfos[0][0] != 'd'
                        select directoryInfos[8]).Any(
                        name => name == fileName);
        }

        /// <summary>
        /// FTP 풀 경로에서 Directory 경로만 가져옵니다.
        /// </summary>
        /// <param name="ftpFilePath">FTP 풀 경로</param>
        /// <returns>디렉터리 경로입니다.</returns>
        private string GetDirectoryPath(string ftpFilePath)
        {
            string[] datas = ftpFilePath.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            string directoryPath = string.Empty;

            for ( int i = 0 ; i < datas.Length - 1 ; i++ )
            {
                directoryPath += string.Format("/{0}", datas[i]);
            }
            return directoryPath;
        }

        /// <summary>
        /// FTP 풀 경로에서 파일이름만 가져옵니다.
        /// </summary>
        /// <param name="ftpFilePath">FTP 풀 경로</param>
        /// <returns>파일명입니다.</returns>
        private string GetFileName(string ftpFilePath)
        {
            string[] datas = ftpFilePath.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            return datas[datas.Length - 1];
        }


        /// <summary>
        /// 파일명 리스트 구하기
        /// </summary>
        /// <param name="dirPath">서버 디렉토리</param>
        /// <returns>파일명 리스트</returns>
        public List<string> GetFileNameList(string dirpath)
        {
            List<string> fileNameList = new List<string>();

            string URI = string.Format("{0}/{1}", this.Host, dirpath);
            System.Net.FtpWebRequest ftp = GetRequest(URI);
            ftp.Method = System.Net.WebRequestMethods.Ftp.ListDirectory;

            //WebResponse webResponse = null;
            try
            {
                string str = GetStringResponse(ftp);
                string[] filesInDirectory = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for ( int i = 0 ; i < filesInDirectory.Length ; i++ )
                {
                    string filename = filesInDirectory[i].Substring(filesInDirectory[i].LastIndexOf("/") + 1);
                    if(filename.Length >= 4)
                        fileNameList.Add(filename);
                }
            }
            catch ( Exception ex ) { throw ex; }

            return fileNameList;
        }
 

        /// <summary>
        /// FTP 경로의 디렉토리를 점검하고 없으면 생성
        /// </summary>
        /// <param name="directoryPath">디렉터리 경로 입니다.</param>
        public void FTPDirectioryCheck(string directoryPath)
        {
            string[] directoryPaths = directoryPath.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

            string currentDirectory = string.Empty;
            foreach ( string directory in directoryPaths )
            {
                currentDirectory += string.Format("/{0}", directory);
                if ( !IsExtistDirectory(currentDirectory) )
                {
                    MakeDirectory(currentDirectory);
                }
            }
        }

        /// <summary>
        /// FTP에 해당 디렉터리가 있는지 알아온다.
        /// </summary>
        /// <param name="currentDirectory">디렉터리 명</param>
        /// <returns>있으면 참</returns>
        private bool IsExtistDirectory(string currentDirectory)
        {
            string ftpFileFullPath = string.Format("{0}{1}", this.Host, GetParentDirectory(currentDirectory));
            FtpWebRequest ftpWebRequest = WebRequest.Create(new Uri(ftpFileFullPath)) as FtpWebRequest;
            ftpWebRequest.Credentials = new NetworkCredential(this.UserName, this.Password);
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.UsePassive = true;
            ftpWebRequest.Timeout = 10000;
            ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = null;
            string data = string.Empty;
            try
            {
                response = ftpWebRequest.GetResponse() as FtpWebResponse;
                if ( response != null )
                {
                    StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.Default);

                    data = streamReader.ReadToEnd();
                }
            }
            finally
            {
                if ( response != null )
                {
                    response.Close();
                }
            }

            string[] directorys = data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return (from directory in directorys
                    select directory.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        into directoryInfos
                        where directoryInfos[0][0] == 'd'
                        select directoryInfos[8]).Any(
                        name => name == (currentDirectory.Split('/')[currentDirectory.Split('/').Length - 1]).ToString());
        }

        /// <summary>
        /// 상위 디렉터리를 알아옵니다.
        /// </summary>
        /// <param name="currentDirectory"></param>
        /// <returns></returns>
        private string GetParentDirectory(string currentDirectory)
        {
            string[] directorys = currentDirectory.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            string parentDirectory = string.Empty;
            for ( int i = 0 ; i < directorys.Length - 1 ; i++ )
            {
                parentDirectory += "/" + directorys[i];
            }

            return parentDirectory;
        }

        /// <summary>
        /// 인증을 가져옵니다.
        /// </summary>
        /// <returns>인증</returns>
        private ICredentials GetCredentials()
        {
            return new NetworkCredential(this.UserName, this.Password);
        }

        private string GetStringResponse(FtpWebRequest ftp)
        {
            string result = "";
            using ( FtpWebResponse response = (FtpWebResponse)ftp.GetResponse() )
            {
                long size = response.ContentLength;
                using ( Stream datastream = response.GetResponseStream() )
                {
                    if ( datastream != null )
                    {
                        using ( StreamReader sr = new StreamReader(datastream) )
                        {
                            result = sr.ReadToEnd();
                            sr.Close();
                        }

                        datastream.Close();
                    }
                }

                response.Close();
            }

            return result;
        }

        private FtpWebRequest GetRequest(string URI)
        {
            FtpWebRequest result = (FtpWebRequest)WebRequest.Create(URI);
            result.Credentials = GetCredentials();
            result.KeepAlive = false;
            return result;
        }

        /// <summary>
        /// FTP에 해당 디렉터리를 만든다.
        /// </summary>
        /// <param name="dirpath"></param>
        public bool MakeDirectory(string dirpath)
        {
            string URI = string.Format("{0}/{1}", this.Host, dirpath);
            System.Net.FtpWebRequest ftp = GetRequest(URI);
            ftp.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory;

            try
            {
                string str = GetStringResponse(ftp);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 지정한 로컬 파일이 실제 존재하는지 확인합니다.
        /// </summary>
        /// <param name="localFileFullPath">로컬 파일의 전체 경로입니다.</param>
        private void LocalFileValidationCheck(string localFileFullPath)
        {
            if ( !File.Exists(localFileFullPath) )
            {
                throw new FileNotFoundException(string.Format("지정한 로컬 파일이 없습니다.\n경로 : {0}", localFileFullPath));
            }
        }



        /// <summary>
        /// Delete remote file
        /// </summary>
        /// <param name="filename">filename or full path</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool DeleteFile(string filename)
        {
            //Determine if file or full path
            string URI = this.Host + filename;

            System.Net.FtpWebRequest ftp = GetRequest(URI);
            //Set request to delete
            ftp.Method = System.Net.WebRequestMethods.Ftp.DeleteFile;
            try
            {
                //get response but ignore it
                string str = GetStringResponse(ftp);
                //Give Message of Command
                NewMessageEventArgs e = new NewMessageEventArgs("COMMAND", "Delete File", "DELE");
                //OnNewMessageReceived(this, e);
            }
            catch ( Exception )
            {
                return false;
            }
            return true;
        }

        private string AdjustDir(string path)
        {
            return ((path.StartsWith("/")) ? "" : "/").ToString() + path;
        }


        /// <summary>
        /// 디렉토리 전체를 삭제
        /// </summary>
        /// <param name="dirpath">파일이 존재하는 디렉토리 (DONGSHIN 이하 전부 기입)</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool DeleteDirectory(string dirpath)
        {
            try
                {
                    //실제로 디렉토리가 존재하면 삭제 실행
                    if ( IsExtistDirectory(dirpath) ) 
                    {

                        //디렉토리 안에 파일이 존재하면 삭제 후 디렉토리 삭제
                        List<string> fileNameList = new List<string>();
                        fileNameList = GetFileNameList(dirpath);
                        if ( fileNameList.Count > 0 )
                        {
                            for ( int i = 0 ; i < fileNameList.Count ; i++ )
                            {
                                DeleteFile(string.Format("{0}/{1}", dirpath, fileNameList[i]));
                            }
                        }

                        string URI = this.Host + AdjustDir(dirpath);
                        System.Net.FtpWebRequest ftp = GetRequest(URI);
                        ftp.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory;
                    
                    //get response but ignore it
                    string str = GetStringResponse(ftp);
                    //Give Message of Command
                    NewMessageEventArgs e = new NewMessageEventArgs("COMMAND", "Remove Directory", "RMD");
                    //OnNewMessageReceived(this, e);
                    }
                }
                catch ( Exception )
                {
                    return false;
                }
                return true;
            
        }
        #endregion

    }
}
