using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DONGSHIN
{
    public class LanguageDesc
    {
        public string FileName { get; set; }
        public string Language;
        public string DisplayName { get; set; }
        public string Version;
        public string Company;
        public string Author;
        public DateTime CreateTime;
        public DateTime ModifyTime;
    }

    public class LanguageChoice
    {
        public static string _UILanguage = "";
        public static void ConvertUILanguage(System.Windows.Forms.Control pBaseControl)
        {
            LanguageSet LangSetter = new LanguageSet();

            switch ( commonVar.whichLang )
            {
                case "中國語":
                    _UILanguage = "SmartQLocal-CN";
                    break;
                case "English":
                    _UILanguage = "TRANSLATE-ENG";
                    break;
            }
            LangSetter.SetLanguage(_UILanguage); ;
            LangSetter.ConvertUILanguage(pBaseControl);
        }

    }


    public class LanguageSet
    {
        private const string _SplitCHAR = ".";
        private string _Path;
        private List<LanguageDesc> _File;

        public LanguageSet()
        {
            _Path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "");
            if ( !Directory.Exists(_Path) )
                throw new Exception("Path not exists: " + _Path);
            //_Path = path;
        }


        public void switchLanguage(Control sender)
        {
            string cPrn파일명 = "";
            FileInfo Xml_File;

            switch ( commonVar.whichLang )
            {
                case "中國語":
                    cPrn파일명 = Application.StartupPath + "/SmartQLocal-CN.xml";

                    Xml_File = new FileInfo(cPrn파일명);


                    if ( Xml_File.Exists == true )
                    {
                        string lang = "SmartQLocal-CN";
                        LanguageSet langSetter = new LanguageSet();
                        Control control = sender;
                        langSetter.SetLanguage(lang);
                        langSetter.ConvertUILanguage(sender);
                    }
                    break;

                case "English":
                    cPrn파일명 = Application.StartupPath + "/TRANSLATE-ENG.xml";

                    Xml_File = new FileInfo(cPrn파일명);


                    if ( Xml_File.Exists == true )
                    {
                        string lang = "TRANSLATE-ENG";
                        LanguageSet langSetter = new LanguageSet();
                        Control control = sender;
                        langSetter.SetLanguage(lang);
                        langSetter.ConvertUILanguage(sender);
                    }
                    break;

                default:
                    break;
            }
        }

        #region SetLanguage
        public void SetLanguage(string pLanguage)
        {

            string fileName = Path.Combine(_Path, pLanguage + ".xml");
            if ( !File.Exists(fileName) )
            {
                if ( (_File == null) || (_File.Count == 0) )
                {
                    EnumLanguages();
                }
                if ( (_File != null) && (_File.Count > 0) )
                {
                    fileName = _File[0].FileName;

                }
                if ( !File.Exists(fileName) )
                    throw new Exception("Cannot find the language file: " + fileName);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
                SetLanguage(xmlDoc.DocumentElement);
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
                SetLanguage(xmlDoc.DocumentElement);
            }
        }

        public void SetLanguage(XmlNode pXNode)
        {
            if ( pXNode == null ) return;

            if ( pXNode.ChildNodes.Count >= 1 )
                XmlHelper._RootNode = pXNode;
        }
        #endregion


        #region EnumLanguages
        public LanguageDesc[] EnumLanguages(string pPath)
        {
            List<LanguageDesc> result = new List<LanguageDesc>();
            XmlDocument xmlDoc = new XmlDocument();
            DirectoryInfo DirInfo = new DirectoryInfo(pPath);
            foreach ( FileInfo fi in DirInfo.GetFiles("*.xml") )
            {
                LanguageDesc lDesc = new LanguageDesc();
                result.Add(lDesc);
                lDesc.FileName = fi.FullName;
                xmlDoc.Load(fi.FullName);
                XmlElement root = xmlDoc.DocumentElement;
                XmlNode xNode = root.SelectSingleNode("language");
                if ( xNode != null ) lDesc.Language = XmlHelper.GetNodeText(xNode);
                xNode = root.SelectSingleNode("displayName");
                if ( xNode != null ) lDesc.DisplayName = XmlHelper.GetNodeText(xNode);
                xNode = root.SelectSingleNode("version");
                if ( xNode != null ) lDesc.Version = XmlHelper.GetNodeText(xNode);
            }
            _File = result;
            return result.ToArray();
        }

        public LanguageDesc[] EnumLanguages()
        {
            return EnumLanguages(this._Path);
        }
        #endregion


        static public void SetPropertyValue(object pClassInstance, string pPropertyName, string pKorean, object pValue)
        {
            try
            {
                Type myType = pClassInstance.GetType();
                PropertyInfo myPropertyInfo = myType.GetProperty(pPropertyName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if ( myPropertyInfo != null )
                {
                    if ( myPropertyInfo.PropertyType.Name.StartsWith("Int") )
                        myPropertyInfo.SetValue(pClassInstance, int.Parse(pValue.ToString()), null);
                    else
                    {
                        try
                        {
                            //Control Text 
                            object tmpClassText = myPropertyInfo.GetValue(pClassInstance, null);
                            string tmpStr = string.Empty;

                            if ( tmpClassText.ToString().IndexOf(tmpStr) > -1 )
                                tmpStr = tmpClassText.ToString().Replace(tmpStr, pValue.ToString());
                            myPropertyInfo.SetValue(pClassInstance, tmpStr, null);
                        }
                        catch
                        {
                            myPropertyInfo.SetValue(pClassInstance, pValue, null);
                        }
                    }
                }
            }
            catch { }
        }



        public object GetPropertyValue(object pClassInstance, string pPropertyName)
        {
            try
            {
                Type myType = pClassInstance.GetType();
                PropertyInfo myPropertyInfo = myType.GetProperty(pPropertyName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if ( myPropertyInfo == null )
                    return null;
                else
                    return myPropertyInfo.GetValue(pClassInstance, null);
            }
            catch
            {
                return null;
            }
        }



        #region ConvertUILanguage
        public void ConvertUILanguage(Control pBaseControl)
        {
            if ( XmlHelper._RootNode == null ) return;
            System.Reflection.FieldInfo[] fieldInfo =
                pBaseControl.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);


            for ( int i = 0 ; i < fieldInfo.Length ; i++ )
            {
                try
                {
                    string key = string.Empty;
                    string text = string.Empty;
                    if ( GetControlKey(pBaseControl, fieldInfo[i], out key, out text) )
                    {
                        if(commonVar.whichLang=="English")
                            DoConvertUILanguageToEng(pBaseControl, fieldInfo[i]);
                    }
                }
                catch { }
            }

        }

        #endregion

        #region Do ConvertUILanguage
        protected virtual bool GetControlKey(Control pBaseControl, FieldInfo pFieldInfo, out string pKey, out string pText) //컨트롤이름과 컨트롤내부텍스트 읽어옴
        {
            pKey = string.Empty;
            pText = string.Empty;
            try
            {
                object target = null;
                target = pFieldInfo.GetValue(pBaseControl);
                if ( target == null )
                {
                    return false;
                }
                PropertyInfo pInfo = target.GetType().GetProperty("Name");
                if ( pInfo == null ) return false;
                string xx = (string)pInfo.GetValue(target, null);
                if ( !string.IsNullOrEmpty(xx) )
                {
                    pKey = pBaseControl.GetType().Name + _SplitCHAR + xx;
                    if ( target.GetType().Name == "GridView" )
                    {
                        DevExpress.XtraGrid.Views.Grid.GridView GridView = (DevExpress.XtraGrid.Views.Grid.GridView)target;
                        pText = GridView.GroupPanelText;

                        for ( int x1 = 0 ; x1 < GridView.Columns.Count ; x1++ )
                        {
                            string tmpName = GridView.Columns[x1].Caption;
                            System.Xml.XmlNode ctlNode = XmlHelper._RootNode.SelectSingleNode(tmpName);
                            if ( ctlNode == null )
                                continue;
                            if ( ctlNode.InnerText != null && ctlNode.InnerText != "" )
                                GridView.Columns[x1].Caption = ctlNode.InnerText;
                        }
                    }
                    else if ( target.GetType().Name == "GridColumn" || target.GetType().Name == "BandedGridColumn" )
                    {
                        DevExpress.XtraGrid.Columns.GridColumn GridCol = (DevExpress.XtraGrid.Columns.GridColumn)target;
                        
                        pText = GridCol.Caption;
                        //pText = GridCol.OptionsEditForm.Caption;
                    }
                    else if(target.GetType().Name == "GridBand" )
                    {
                        DevExpress.XtraGrid.Views.BandedGrid.GridBand Band = (DevExpress.XtraGrid.Views.BandedGrid.GridBand)target;
                        pText = Band.Caption;
                    }
                    else
                    {
                        pText = GetPropertyValue(target, "Text").ToString();
                    }
                    //try
                    //{
                    //    if ( pText.IndexOf(":") > 0 )
                    //        pText = pText.Replace(":", "");
                    //    if ( pText.IndexOf("(") > 0 )
                    //    {
                    //        pText = pText.Replace(pText.Substring(pText.IndexOf("(")), "");
                    //        pText = pText.Replace(")", "");
                    //    }
                    //}
                    //catch
                    //{

                    //}
                    return true;
                }
            }
            catch { }
            return false;
        }

        public virtual void DoConvertUILanguageToEng(Control pBaseControl, FieldInfo pFieldInfo) //한->영
        {
            if ( XmlHelper._RootNode == null ) return;
            string key = string.Empty;
            string text = string.Empty;
            object target = null;
            target = pFieldInfo.GetValue(pBaseControl);
            if ( GetControlKey(pBaseControl, pFieldInfo, out key, out text) )
            {
                if ( text == null || text == "" )
                    return;

                if ( (target != null) && (!string.IsNullOrEmpty(text)) )
                {
                    try
                    {
                        string xpath = "//control[kor='" + text + "']"; //xpath에 조건을 걸어서 검색
                        XmlNode ctlNode = XmlHelper._RootNode.SelectSingleNode(xpath);
                        if ( ctlNode == null )
                            return;
                        else
                        {
                            {
                                if ( target is DevExpress.XtraGrid.Columns.GridColumn )
                                {
                                    DevExpress.XtraGrid.Columns.GridColumn GridCol = (DevExpress.XtraGrid.Columns.GridColumn)target;
                                    GridCol.Caption = XmlHelper.GetNodeText(ctlNode);
                                    GridCol.OptionsEditForm.Caption = XmlHelper.GetNodeText(ctlNode);
                                }

                                string eng = XmlHelper.GetNodeText(ctlNode);
                                if ( !string.IsNullOrEmpty(eng) )
                                    SetPropertyValue(target, "Text", text, eng);
                            }

                        }
                    }
                    catch
                    { }
                }

            }
        }


        #endregion


    }
}
