using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace DONGSHIN
{
    public class commonVar
    {
        #region DB연결 관련 변수

        public static SqlConnection DBconn = new SqlConnection();
        public static string dbConnectionString;
        public static void setDbConString(string serverName, string dbName, string userId, string userPw)
        {
            dbConnectionString = "Data Source=" + serverName + "; Initial Catalog=" + dbName + "; User Id=" + userId + "; Password=" + userPw + ";";
        }
        
        #endregion

        public static bool IsServerRunning { get; set; }
        public static string  ServerPublicIpAddress { get; set;}
        public static string ServerPrivateIpAddress { get; set; }
        public static int ServerPublicPort { get; set; }
        public static int ServerPrivatePort { get; set; }
        public static bool IsThisServer { get; set; }
        public static string CompanyCode { get; set; }
        
        #region AppInfo.xml 관련 변수

        public static string version = string.Empty;

        #endregion

        #region frm_login

        public static bool loadingIsDone = false;
        public static string login_id="";
        public static string login_name = "";
        public static string user_gbn = "";
        public static string whichLang = "한국어"; //언어선택

        #endregion       


        #region FormGridSetting

        public static String PATH = Application.StartupPath;

        #endregion

        #region 이미지 FTP관련 변수
        //--------------------------------------------------------------------//
        //------------------ftp서버정보, 보안문제 등 수정 할 예정
        public static string userFTPServerIP = "ftp://iup.cdn3.cafe24.com:21/DONGSHIN/";
        public static string userFTPID = "drumshow1";
        public static string userFTPPassword = "dasa0905";
        //--------------------------------------------------------------------//
        #endregion

        #region 권한설정 관련 변수

        public static DataTable userPermissionInfo;

        #endregion

        #region 날짜 설정 변수

        public static DateTime getDate = DateTime.Today;
        public static  DateTime startDate = getDate.AddDays(1 - getDate.Day);
        public static DateTime endDate = getDate.AddMonths(1).AddDays(0 - getDate.Day);
        public static string startOfMonth = startDate.ToShortDateString();
        public static string endOfMonth = endDate.ToShortDateString();
        public static string today = getDate.ToShortDateString();
        public static string dayOfWeek = getDate.DayOfWeek.ToString();

        #endregion

        public static string whichLanguage { get; set; }

    }
}
