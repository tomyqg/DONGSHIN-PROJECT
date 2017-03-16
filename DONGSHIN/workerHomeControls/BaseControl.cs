using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class BaseControl : UserControl
    {

        public Dictionary<string, Control> TextEditors = new Dictionary<string, Control>();
        public BaseControl()
        {
            InitializeComponent();
        }

        protected virtual void AddTextEditor() { }

        public string[] getFieldCodes()
        {
            string[] fieldCodes = TextEditors.Keys.ToArray();
            return fieldCodes;
        }

        public void DisplayData(Dictionary<string, string> data)
        {
            if (data != null)
            {
                string[] fieldCodes = data.Keys.ToArray();
                for (int i = 0; i < fieldCodes.Length; i++)
                {
                    string fieldCode = fieldCodes[i];
                    if (TextEditors.ContainsKey(fieldCode))
                    {
                        setTextToEditor(data[fieldCode], TextEditors[fieldCode]);
                        
                    }
                }
            }
           
        }



        
        // add text
        public delegate void setText(string text, Control editor);
        private void setTextToEditor(string text, Control textEditor)
        {
            try
            {
                if ( textEditor.InvokeRequired )
                {
                    // 작업쓰레드인 경우
                    setText callback = new setText(setTextToEditor);
                    this.Invoke(callback, new Object[] { text, textEditor });
                }
                else
                {
                    // UI 쓰레드인 경우
                    textEditor.Text = text;
                }
            }
            catch { }
        }
        
        public virtual void setControlLanguage() 
        {
            commonFX.setThisLanguage(this);
        }

    }
}
