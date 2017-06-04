using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DONGSHIN.Settings
{
    class SettingHelper
    {
        static string xmlFilePath = Application.StartupPath + @"\Settings.xml";

        public static void SaveSetting(string name, string value)
        {
            XElement doc = XElement.Load(xmlFilePath);
            
            XElement element;
            if ((element = doc.Element(name)) != null)
                element.Value = value;
            else
            {
                element = new XElement(name, value);
                doc.Add(element);
            }

            doc.Save(xmlFilePath);
        }

        public static string ReadSetting(string name)
        {
            XElement doc = XElement.Load(xmlFilePath);
            XElement element;
            if ((element = doc.Element(name)) != null)
                return element.Value;
            else
                return string.Empty;
        }

        public static bool IsStandAlone()
        {
            FileInfo fi = new FileInfo(Application.StartupPath+"\\standalone");
            if (fi.Exists)
                return true;
            return false;

        }

        static SettingHelper()
        {
            
            FileInfo xmlFileInfo = new FileInfo(xmlFilePath);
            if (xmlFileInfo.Exists == false)
            {
                XElement doc = new XElement("Settings");
                
                XElement autoLogin = new XElement("AutoLogin");
                doc.Add(autoLogin);
                XElement userId = new XElement("UserId");
                doc.Add(userId);
                XElement language = new XElement("Language");
                doc.Add(language);
                XElement dataSaveLocation = new XElement("LocalFilePath");
                doc.Add(dataSaveLocation);

                doc.Save(xmlFilePath);
            }
        }


    }
}
