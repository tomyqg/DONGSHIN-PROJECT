using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ModbusTcp
{
    public static class LogWriter
    {
        public static string FileBasePath { get; set; }
        public static void WriteLog_Data(string msg, string title, string machineCode)
        {
            string filePath = FileBasePath + @"\Logs\Data\log" +
                DateTime.Today.ToString("yyyyMMdd") + "-" + title + "-" + machineCode + ".txt";
            string directoryPath = FileBasePath + @"\Logs\Data";

            DirectoryInfo di = new DirectoryInfo(directoryPath);

            try
            {
                if (di.Exists == false)
                    Directory.CreateDirectory(directoryPath);

                DateTime now = DateTime.Now;
                string text = now.ToString("HH:mm:ss:") + now.Millisecond.ToString("###");
                text += "\n" + msg;

                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                WriteLog_Error(ex, filePath + "  " + msg);
            }
        }
        /// <summary>
        /// 로그기록.
        /// </summary>
        /// <param name="option">추가로 기록할 내용</param>
        public static void WriteLog_Error(Exception ex, string option = "")
        {
            string stacktrace = ex.StackTrace;
            string message = ex.Message;
            string filePath = FileBasePath + @"\Logs\Errors\log" +
                DateTime.Today.ToString("yyyyMMdd") + ".txt";
            string directoryPath = FileBasePath + @"\Logs\Errors";

            DirectoryInfo di = new DirectoryInfo(directoryPath);

            try
            {
                if (di.Exists == false)
                    Directory.CreateDirectory(directoryPath);

                DateTime now = DateTime.Now;
                string text = now.ToString("HHmmss") + now.Millisecond.ToString("###") + " : ";

                text += "Message: " + message + "\n";
                if (stacktrace.Length > 0)
                    text += "StackTrace: " + stacktrace + "\n";
                if (option.Length > 0)
                    text += "option: " + option;

                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
            }
            catch
            {
            }
        }





    }
}
