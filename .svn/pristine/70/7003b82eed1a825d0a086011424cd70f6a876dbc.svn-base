using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;


namespace DONGSHIN
{
    static class Program
    {
        public static ApplicationContext ac = new ApplicationContext();

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            #region AppInfo.xml 데이터 읽어오는 과정
            string fileName = "";
            string appVersion = "";
            string appAddress = "";

            fileName = Application.StartupPath + "\\AppInfo.xml";

            XmlDocument xDoc = new XmlDocument();

            try
            {
                xDoc.Load(fileName);

                XmlNodeList nodeList = xDoc.GetElementsByTagName("AppInfo");
                appVersion = nodeList[0]["version"].InnerText;

                commonVar.version = appVersion;

                XmlNodeList nodeList2 = xDoc.GetElementsByTagName("ServerInfo");
                appAddress = nodeList2[0]["addr"].InnerText;
            }
            catch { }
            #endregion

            frm_login login = new frm_login();
            ac.MainForm = login;
            Application.Run(ac);           

        }
    }
}
