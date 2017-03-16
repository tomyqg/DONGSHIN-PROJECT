using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;


namespace UPDATE
{
    public static class Version
    {
        public static DataSet _remoteDS = new DataSet();
        public static DataSet _localDS = new DataSet();
        public static string _ExecuteFile = "";
        public static string _LocalPath = "";
        public static string _remoteURL = "http://update.pdmtech.co.kr:6603/DONGSHIN/";
        public static string[] _DownloadFile;
        private static string _localVersion;
        private static string _remoteVersion;
        private static string _downloadToPath;

        public static void CompareVersions(out string localVersion, out string remoteVersion)
        {
            Version._downloadToPath = Application.StartupPath;
            try
            {
                localVersion = Version.LocalVersion("AppInfo.xml");
                remoteVersion = Version.RemoteVersion("AppInfo.xml");
            }catch(Exception ex)
            {
                throw;
            }
            
        }

        public static string RemoteVersion(string pFNM)
        {
            string str;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Version._remoteURL + pFNM);

                XmlElement root = doc.LastChild as XmlElement;
                XmlNodeList list = root.ChildNodes;

                Version._ExecuteFile = list.Item(1).FirstChild.InnerText;
                str = list.Item(1).FirstChild.NextSibling.InnerText;
                XmlElement file = list.Item(0) as XmlElement;
                IEnumerator ienum = list.Item(0).GetEnumerator();

                int i = 0;
                Version._DownloadFile = new string[file.ChildNodes.Count];
                while ( ienum.MoveNext() )
                {
                    Version._DownloadFile[i] = file.InnerText;
                    i++;
                }
                return str;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            
        }

        public static string LocalVersion(string filename)
        {
            try
            {
                string str = "";
                Version._LocalPath = Application.StartupPath + "\\" + filename;
                if ( string.IsNullOrEmpty(Version._LocalPath) || ((IEnumerable<char>)Path.GetInvalidPathChars()).Intersect<char>((IEnumerable<char>)Version._LocalPath.ToCharArray()).Count<char>() != 0 || !new FileInfo(Version._LocalPath).Exists )
                    str = (string)null;
                else if ( new FileInfo(Version._LocalPath).Exists )
                {
                    XmlDocument doc = new XmlDocument();
                    
                    doc.Load(Version._LocalPath);
                    _localDS.ReadXml(Version._LocalPath);
                    XmlElement root = doc.LastChild as XmlElement;

                    XmlNodeList list = root.ChildNodes;
                    str = list.Item(1).FirstChild.NextSibling.InnerText;
                }
                return str;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
        }

        public static bool ValidateFile(string contents)
        {
            bool flag = false;
            if ( !string.IsNullOrEmpty(contents) )
                flag = new Regex("^([0-9]*\\.){3}[0-9]*$").IsMatch(contents);
            return flag;
        }


        public static string CreateLocalVersionFile(string folderPath, string fileName, string version)
        {
            if ( !new DirectoryInfo(folderPath).Exists )
                Directory.CreateDirectory(folderPath);
            string str = folderPath + "\\" + fileName;
            if ( new FileInfo(str).Exists )
                new FileInfo(str).Delete();
            if ( !new FileInfo(str).Exists )
                System.IO.File.WriteAllText(str, version);
            return str;
        }

        public static string CreateTargetLocation(string downloadToPath, string version)
        {
            if ( !downloadToPath.EndsWith("\\") )
                downloadToPath += "\\";
            string path = downloadToPath + version;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if ( directoryInfo.Exists )
                return path;
            directoryInfo.Create();
            return path;
        }
    }
}
