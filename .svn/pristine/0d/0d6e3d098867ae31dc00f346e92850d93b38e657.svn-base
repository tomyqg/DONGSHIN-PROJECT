using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using DevExpress.XtraGrid;

namespace DONGSHIN
{
    public class commonFX //여러 메뉴에서 공통으로 쓰이는 함수
    {
        public static DevExpress.XtraGrid.Views.Grid.GridView gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        public static String grTITLE;


        #region contextMenuStrip

        public static void fGrid현재값검색(DevExpress.XtraGrid.Views.Grid.GridView gridView1)
        {
            try
            {
                String fiName = Convert.ToString(gridView1.FocusedColumn.FieldName);
                String fiText = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[fiName]));
                gridView1.Columns[fiName].FilterInfo = new ColumnFilterInfo(null, gridView1.GetRowCellValue(gridView1.FocusedRowHandle, fiName), fiText);
            }
            catch ( Exception ex )
            {
                MessageBox.Show("그룹으로 묶인필드는 검색할 수 없습니다. → " + ex.Message);
            }
        }


        public static void fGrid검색취소(DevExpress.XtraGrid.Views.Grid.GridView gridView1)
        {
            try
            {
                String fiName = Convert.ToString(gridView1.FocusedColumn.FieldName);
                gridView1.Columns[fiName].FilterInfo = new ColumnFilterInfo();
            }
            catch ( Exception ex )
            {
                MessageBox.Show("그룹으로 묶인필드는 취소할 수 없습니다. → " + ex.Message);
            }
        }

        #endregion

        #region FormGridSetting

        public static void Layout_Save(DevExpress.XtraGrid.Views.Grid.GridView gridView2, String sTITLE)
        {
            gridView1 = gridView2;
            sTITLE = sTITLE.Replace(" ", "");
            grTITLE = (sTITLE + ".Xml");
            String LayoutPath = commonVar.PATH + "/Layout/" + grTITLE;

            try
            {
                if ( System.IO.Directory.Exists(commonVar.PATH + "/Layout/") == true )
                {
                    if ( System.IO.File.Exists((LayoutPath)) == true )
                    {
                        System.IO.File.Delete(LayoutPath);
                    }
                    gridView1.SaveLayoutToXml(LayoutPath);
                }
                else
                {
                    System.IO.Directory.CreateDirectory(commonVar.PATH + "/Layout/");
                    gridView1.SaveLayoutToXml(LayoutPath);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Layout_Save → " + ex.Message);
            }
        }

        public static void Layout_Load(DevExpress.XtraGrid.Views.Grid.GridView gridView2, String sTITLE)
        {
            gridView1 = gridView2;
            sTITLE = sTITLE.Replace(" ", "");
            grTITLE = (sTITLE + ".Xml");
            String LayoutPath = commonVar.PATH + "/Layout/" + grTITLE;

            try
            {
                if ( System.IO.File.Exists(LayoutPath) == true )
                {
                    gridView1.RestoreLayoutFromXml(LayoutPath);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Layout_Load → " + ex.Message);
            }
        }


        public static void Layout_Dele(String sTITLE)
        {
            sTITLE = sTITLE.Replace(" ", "");
            grTITLE = (sTITLE + ".Xml");
            String LayoutPath = commonVar.PATH + "/Layout/" + grTITLE;

            try
            {
                if ( (System.IO.File.Exists(LayoutPath) == true) )
                {
                    System.IO.File.Delete(LayoutPath);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Layout_Dele → " + ex.Message);
            }
        }

        #endregion

        #region 참조 관련



           //참조창 띄울때 배경처리를 위한 함수(레이블 배경 이미지 투명도 조절)
           public static Bitmap change_opacity(Image img, float opacityvalue) 
           {
               Bitmap bmp = new Bitmap(img.Width, img.Height);
               Graphics graphics = Graphics.FromImage(bmp);
               ColorMatrix colormatrix = new ColorMatrix();
               colormatrix.Matrix33 = opacityvalue;
               ImageAttributes imgAttribute = new ImageAttributes();
               imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
               graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
               graphics.Dispose();
               return bmp;
           }
        #endregion 

        #region 콤보박스 아이템 읽어오기

           public static void commonRef(string target, ComboBoxEdit cbx)//target : 공통그룹명, cbx : 대상이 되는 컨트롤
           {
               DataSet cbxList = new DataSet();

               if ( commonVar.DBconn.State == ConnectionState.Closed )
                   commonVar.DBconn.ConnectionString = commonVar.dbConnectionString;

               try
               {
                   commonReturn Return = new commonReturn();
                   Return = fx_commonCode.findForRef(commonVar.DBconn, target);

                   if ( Return.Message == "" )
                       cbxList = Return.Dataset;
                   else
                       MessageBox.Show("DB연결 에러", "코드 읽기 오류");

                   //아이템추가
                   int i;
                   cbx.Properties.Items.Clear();
                   if ( cbxList.Tables[0].Rows.Count > 0 )
                   {
                       for ( i = 0 ; i < cbxList.Tables[0].Rows.Count ; i++ )
                       {
                           cbx.Properties.Items.Add(Convert.ToString(cbxList.Tables[0].Rows[i]["gt_name"]));
                       }
                   }
               }
               catch
               {
                   cbx.Properties.Items.Clear();
                   cbx.Properties.Items.Add("");
               }
           }

        #endregion

        #region 이미지 FTP삭제

           public static void delImg(string path)
           {
               try
               {
                   FtpWebRequest req = (FtpWebRequest)WebRequest.Create(path);
                   req.Credentials = new NetworkCredential(commonVar.userFTPID, commonVar.userFTPPassword);
                   req.Method = WebRequestMethods.Ftp.DeleteFile;
                   FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                   response.Close();

               }
               catch ( Exception ex )
               {
                   MessageBox.Show(ex.Message, "이미지 삭제 실패");
                   return;
               }
           }

        #endregion

        #region 언어설정

           public static void setThisLanguage(Control control)
           {
               LanguageSet langSetter = new LanguageSet();
               langSetter.switchLanguage(control);
           }

        #endregion
    }//class
}//namespace
