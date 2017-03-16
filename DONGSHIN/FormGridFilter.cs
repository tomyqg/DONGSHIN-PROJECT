using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;


namespace DONGSHIN
{
    public partial class FormGridFilter : Form
    {
        private GridView GridView1 = new GridView();
        private BandedGridView BandView1 = new BandedGridView();
        private DataSet dv = new DataSet();
        private string c조건내용;

        private bool useGridView =true;

        //-------------------------------------------------------------------------------------------------------------
        public FormGridFilter()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------
        public void Grid넘기기(ref DataSet dv2, ref GridView GridView2)
        {
            GridView1 = GridView2;
            dv = dv2;
            useGridView = true;
        }

        public void BandGrid넘기기(ref DataSet dv2, ref BandedGridView GridView2)
        {           
            BandView1 = GridView2;

            dv = dv2;
            useGridView = false;
        }

        //-------------------------------------------------------------------------------------------------------------
        private void 컬럼넣기()
        {
            
            text필드명.Properties.Items.Clear();
            text컬럼명.Properties.Items.Clear();
            text컬럼명2.Properties.Items.Clear();

            if ( useGridView )
            {
                for ( int i = 0 ; i < GridView1.Columns.Count ; i++ )
                {
                    if ( GridView1.Columns[i].Visible == true )
                    {
                        text필드명.Properties.Items.Add(GridView1.Columns[i].FieldName);
                        text컬럼명.Properties.Items.Add(GridView1.Columns[i].Caption);
                        text컬럼명2.Properties.Items.Add(GridView1.Columns[i].Caption);
                    }
                }

                if ( text필드명.Properties.Items.Count > 0 )
                {
                    c조건내용 = GridView1.Columns[0].FilterInfo.FilterString;
                    if ( c조건내용.Length > 0 )
                    {
                        for ( int i = 0 ; i < text필드명.Properties.Items.Count ; i++ )
                            c조건내용 = c조건내용.Replace("[" + text필드명.Properties.Items[i] + "]", "[" + text컬럼명.Properties.Items[i] + "]");
                    }
                    f조건찾아넣기();
                }
            }
            else 
            {
                for ( int i = 0 ; i < GridView1.Columns.Count ; i++ )
                {
                    if ( BandView1.Columns[i].Visible == true )
                    {
                        text필드명.Properties.Items.Add(BandView1.Columns[i].FieldName);
                        text컬럼명.Properties.Items.Add(BandView1.Columns[i].Caption);
                        text컬럼명2.Properties.Items.Add(BandView1.Columns[i].Caption);
                    }
                }

                if ( text필드명.Properties.Items.Count > 0 )
                {
                    c조건내용 = BandView1.Columns[0].FilterInfo.FilterString;
                    if ( c조건내용.Length > 0 )
                    {
                        for ( int i = 0 ; i < text필드명.Properties.Items.Count ; i++ )
                            c조건내용 = c조건내용.Replace("[" + text필드명.Properties.Items[i] + "]", "[" + text컬럼명.Properties.Items[i] + "]");
                    }
                    f조건찾아넣기();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------
        private void f조건찾아넣기()
        {
            //'MsgBox(c조건내용)
            if (c조건내용.Length > 0)
            {
                int n위치_and = 0;
                int n위치_or = 0;
                int n위치 = 0;

                while (true)
                {
                    n위치_and = 0;
                    n위치_or = 0;
                    n위치_and = c조건내용.IndexOf("and");
                    n위치_or = c조건내용.IndexOf("or");

                    if (n위치_and <= 0 && n위치_or > 0)
                        n위치 = n위치_or + 2;
                    else if (n위치_and > 0 && n위치_or <= 0)
                        n위치 = n위치_and + 3;
                    else if (n위치_and > 0 && n위치_or > 0)
                        n위치 = (n위치_and > n위치_or) ? n위치_or + 2: n위치_and + 3;

                    if (n위치_and <= 0 && n위치_or <= 0)
                    {
                        listBox조건.Items.Add(c조건내용 + " and ");
                        break;
                    }
                    else 
                    {
                        listBox조건.Items.Add(c조건내용.Substring(0, n위치).Trim());
                        c조건내용 = (c조건내용.Substring(n위치 + 1).Trim());
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------
        private void FormGridFilter_Load(object sender, EventArgs e)
        {
            c조건내용 = "";
            컬럼넣기();
        }

        //-------------------------------------------------------------------------------------------------------------
        private void listBox조건_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c조건;
            int n위치;

            if (listBox조건.Items.Count > 0 && listBox조건.SelectedItem != null)
            {
                c조건 = Convert.ToString(listBox조건.SelectedItem).Trim();
                if (c조건.Length > 0)
                {
                    n위치 = c조건.IndexOf("]") + 1;
                    text컬럼명.Text = (c조건.Substring(0, n위치).Replace("[", "").Replace("]", ""));
                    c조건 = c조건.Substring(n위치 + 1).Trim();

                    n위치 = 0;
                    for (int i = 0; i < text비교부호.Properties.Items.Count; i++)
                    {
                        n위치 = c조건.IndexOf(Convert.ToString(text비교부호.Properties.Items[i])) + 1;
                        if (n위치 > 0)
                        {
                            n위치 = n위치 + Convert.ToString(text비교부호.Properties.Items[i]).Length;
                            break;
                        }
                    }

                    if (n위치 > 0)
                    {
                        text비교부호.Text = c조건.Substring(0, n위치).Trim();
                        c조건 = c조건.Substring(n위치 + 1).Trim();
                        if (c조건.IndexOf("]") > 0)
                            Chk컬럼명.Checked = true;
                        else
                            Chk컬럼명.Checked = false;

                        if (Chk컬럼명.Checked == true)
                        {
                            c조건 = c조건.Replace( "and", "").Replace("or", "").Replace("'", "").Trim();
                            text컬럼명2.Text = c조건.Replace("[", "").Replace("]", "").Trim();
                            text값.Text = "";
                        }
                        else
                        {
                            text값.Text = c조건.Replace("and", "").Replace("or", "").Replace("'", "").Trim();
                            text컬럼명2.Text = "";
                        }
                    }
                    else
                    {
                        if (c조건.IndexOf("]") > 0)
                            Chk컬럼명.Checked = true;
                        else
                            Chk컬럼명.Checked = false;
                        
                        if (Chk컬럼명.Checked == true)
                        {
                            c조건 = c조건.Replace("and", "").Replace("or", "").Replace("'", "").Trim();
                            text컬럼명2.Text = c조건.Replace("[", "").Replace("]", "").Trim();
                            text값.Text = "";
                        }
                        else
                        {
                            text값.Text = c조건.Replace("and", "").Replace("or", "").Replace("'", "").Trim();
                            text컬럼명2.Text = "";
                        }
                    }
                }
                else
                {
                    text컬럼명.Text = "";
                    text컬럼명2.Text = "";
                    text비교부호.Text = "";
                    text값.Text = "";
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Button추가_Click(object sender, EventArgs e)
        {
            if (text컬럼명.Text == "")
            {
                MessageBox.Show("컬럼명이 없습니다!", "추가");
                text컬럼명.Focus();
                return;
            }

            string c조건내용 = "";
            //string c조건필드 = "";

            if (Chk컬럼명.Checked == true)
                c조건내용 = "[" + text컬럼명.Text + "] " + text비교부호.Text.Trim() + " [" + text컬럼명2.Text + "] ";
            else
            {
                c조건내용 = "[" + text컬럼명.Text + "] " + text비교부호.Text.Trim() + " ";

                switch (Convert.ToString(dv.Tables[0].Rows[0][Convert.ToString(text필드명.Properties.Items[text컬럼명.SelectedIndex])].GetType()))
                {
                    case "System.String":
                        if (text컬럼명.Text.IndexOf("일자") > 0)
                            if (text값.Text.Length == 10)
                                text값.Text = string.Format("{0:yyyy-MM-dd}", text값.Text);

                        c조건내용 = c조건내용 + "'" + text값.Text + "' ";
                        break;
                    case "System.Decimal": 
                    case "System.Integer":
                    case "System.Int16": 
                    case "System.Int32": 
                    case "System.Long": 
                    case "System.Single": 
                    case "System.Double":
                        if (text값.Text.Length > 0)
                            c조건내용 = c조건내용 + text값.Text + " ";
                        else
                            c조건내용 = c조건내용 + text값.Text + " ";
                        break;
                    default:
                        c조건내용 = c조건내용 + "'" + text값.Text + "' ";
                        break;
                }
            }

            if (ButtonAND.Checked == true)
                c조건내용 = c조건내용 + "and ";
            else
                c조건내용 = c조건내용 + "or ";

            listBox조건.Items.Add(c조건내용);
            Button적용.Enabled = true;
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Button삭제_Click(object sender, EventArgs e)
        {
            if (listBox조건.SelectedIndex >= 0)
            {
                listBox조건.Items.Remove(listBox조건.SelectedItem);
                Button적용.Enabled = true;
            }
            else
                MessageBox.Show("삭제할 항목을 선택하시오!", "삭제");
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Button수정_Click(object sender, EventArgs e)
        {
            string c조건내용;

            if (text컬럼명.Text == "")
            {
                MessageBox.Show("수정할 항목을 선택하세요!", "수정");
                text컬럼명.Focus();
                return;
            }

            if (listBox조건.SelectedIndex >= 0)
            {
                if (Chk컬럼명.Checked == true)
                    c조건내용 = "[" + text컬럼명.Text + "] " + text비교부호.Text.Trim() + " [" + text컬럼명2.Text + "] ";
                else
                {
                    c조건내용 = "[" + text컬럼명.Text + "] " + text비교부호.Text.Trim() + " ";

                    switch (Convert.ToString(dv.Tables[0].Rows[0][Convert.ToString(text필드명.Properties.Items[text컬럼명.SelectedIndex])].GetType()))
                    {
                        case "System.String":
                            if (text컬럼명.Text.IndexOf("일자") > 0)
                                if (text값.Text.Length == 10)
                                    text값.Text = string.Format("{0:yyyy-MM-dd}",text값.Text);
                            c조건내용 = c조건내용 + "'" + text값.Text + "' ";
                            break;
                        case "System.Decimal": 
                        case "System.Integer":
                        case "System.Int16": 
                        case "System.Int32": 
                        case "System.Long": 
                        case "System.Single": 
                        case "System.Double":
                            if (text값.Text.Length > 0)
                                c조건내용 = c조건내용 + text값.Text + " ";
                            else
                                c조건내용 = c조건내용 + text값.Text + " ";
                            break;
                        default: 
                            c조건내용 = c조건내용 + "'" + text값.Text + "' ";
                            break;
                    }
                }

                if (ButtonAND.Checked == true)
                    c조건내용 = c조건내용 + "and ";
                else
                    c조건내용 = c조건내용 + "or ";

                if (listBox조건.Items.Count > 0)
                    listBox조건.Items[listBox조건.SelectedIndex] = c조건내용;
                else
                    listBox조건.Items.Add(c조건내용);

                Button적용.Enabled = true;
            }
            else
                MessageBox.Show("수정할 항목을 선택하시오!", "수정");          
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Button적용_Click(object sender, EventArgs e)
        {
            string c조건내용;
            string c조건필드;
            int n위치_and;
            int n위치_or;
            int n위치 = 0;

            try
            {
                c조건내용 = "";
                c조건필드 = "";
                for (int i = 0; i < listBox조건.Items.Count; i++)
                    c조건내용 = c조건내용 + (listBox조건.Items[i]) + " ";

                n위치_and = c조건내용.LastIndexOf("and");
                n위치_or = c조건내용.LastIndexOf("or");

                if (n위치_and <= 0 && n위치_or > 0)
                    n위치 = n위치_or - 1;
                else if (n위치_and > 0 && n위치_or <= 0)
                    n위치 = n위치_and - 1;
                else if (n위치_and > 0 && n위치_or > 0)
                    n위치 = (n위치_and > n위치_or) ? n위치_and - 1 : n위치_or - 1;

                c조건내용 = c조건내용.Substring(0, n위치);
                c조건필드 = c조건내용.Trim();
                //'MsgBox(c조건내용)

                if (c조건필드.Length > 0)
                    for (int i = 0; i < text컬럼명.Properties.Items.Count; i++)
                        c조건필드 = c조건필드.Replace("[" + text컬럼명.Properties.Items[i] + "]", "[" + text필드명.Properties.Items[i] + "]");

                if ( useGridView )
                {
                    if ( listBox조건.Items.Count > 0 )
                        GridView1.Columns[0].FilterInfo = new ColumnFilterInfo(c조건필드, c조건내용);
                    else
                        GridView1.Columns[0].FilterInfo = new ColumnFilterInfo();
                }
                else 
                {
                    if ( listBox조건.Items.Count > 0 )
                        BandView1.Columns[0].FilterInfo = new ColumnFilterInfo(c조건필드, c조건내용);
                    else
                        BandView1.Columns[0].FilterInfo = new ColumnFilterInfo();
                }


                Button적용.Enabled = false;
            }
            catch
            {
                MessageBox.Show("잘못된 공식입니다.", "주의");
            }
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Button해제_Click(object sender, EventArgs e)
        {
            listBox조건.Items.Clear();
            if ( useGridView )
            {
                GridView1.Columns[0].FilterInfo = new ColumnFilterInfo();
                GridView1.ClearColumnsFilter();
            }
            else 
            {
                BandView1.Columns[0].FilterInfo = new ColumnFilterInfo();
                BandView1.ClearColumnsFilter();
            }
            Button적용.Enabled = false;
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Chk컬럼명_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk컬럼명.Checked ==true)
            {
                text값.Visible = false;
                text컬럼명2.Visible = true;
            }
            else
            {
                text값.Visible = true;
                text컬럼명2.Visible = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Button닫기_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
    }
}