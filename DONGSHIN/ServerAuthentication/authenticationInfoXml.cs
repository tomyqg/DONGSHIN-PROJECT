using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DONGSHIN
{
    public static class authenticationInfoXml
    {

        public static string infoFilePath = Application.StartupPath + "/Authentication/clientAuthInfo.xml";

        public static void writeClientInfo(string code)
        {
            XmlDocument newXmlDoc = new XmlDocument();
            newXmlDoc.AppendChild(newXmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));

            XmlNode root = newXmlDoc.CreateElement("", "ClientInformation", "");
            newXmlDoc.AppendChild(root);

            XmlNode clientCompany = newXmlDoc.CreateElement("ClientCompany");
            root.AppendChild(clientCompany);

            XmlElement companyCode = newXmlDoc.CreateElement("CompanyCode");
            companyCode.InnerText = code;
            clientCompany.AppendChild(companyCode);

            
            FileInfo newXmlFile = new FileInfo(infoFilePath);
            DirectoryInfo xmlFolder = new DirectoryInfo(Application.StartupPath + "/Authentication");

            if ( !xmlFolder.Exists )
                xmlFolder.Create();

            if ( newXmlFile.Exists )
                newXmlFile.Delete();

            newXmlDoc.Save(infoFilePath);
        }

        public static string getCompanyCode() 
        {
            string companyCode = string.Empty;

            FileInfo infoFile = new FileInfo(infoFilePath);

            if ( infoFile.Exists ) 
            {
                XmlDocument existXmlDoc = new XmlDocument();
                existXmlDoc.Load(infoFilePath);

                string xpath = "/ClientInformation/ClientCompany/CompanyCode";
                XmlNode codeNode = existXmlDoc.SelectSingleNode(xpath);

                companyCode = codeNode.InnerText.Trim();
            }

            return companyCode;
        }

    }
}
