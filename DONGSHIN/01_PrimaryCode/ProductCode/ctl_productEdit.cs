using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using DevExpress.XtraEditors;

namespace DONGSHIN
{
    public partial class ctl_productEdit : UserControl
    {
        ctl_productCode productCode;
        public ctl_productEdit(ctl_productCode productCode)
        {
            InitializeComponent();
            this.productCode = productCode;
            commonFX.setThisLanguage(this);
        }

        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;

        private string productID = "";

        private string imgDBpath = "http://drumshow1.cdn3.cafe24.com/DONGSHIN/";
        private SqlCommand cmd;


        public class productImage 
        {
            public PictureEdit ctl { get; set; }
            public string registeredImgName { get; set; }
            public string imgLocalPath { get; set; }
            public string downloadedImgPath { get; set; }
            public string downloadedImgName { get; set; }
            public string parameter { get; set; }
            public productImage() { }
        }

        productImage img1 = new productImage();
        productImage img2 = new productImage();
        productImage img3 = new productImage();
        productImage img4 = new productImage();
        productImage imgStd = new productImage();
        

        private void ctl_productEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;

            //이미지컨트롤 초기화
            img1.ctl = pic_img1;
            img1.downloadedImgName = "";
            img1.downloadedImgPath = "";
            img1.registeredImgName = "";
            img1.imgLocalPath = "";
            img1.parameter = "";
           

            img2.ctl = pic_img2;
            img2.downloadedImgName = "";
            img2.downloadedImgPath = "";
            img2.registeredImgName = "";
            img2.imgLocalPath = "";
            img2.parameter = "";

            img3.ctl = pic_img3;
            img3.downloadedImgName = "";
            img3.downloadedImgPath = "";
            img3.registeredImgName = "";
            img3.imgLocalPath = "";
            img3.parameter = "";

            img4.ctl = pic_img4;
            img4.downloadedImgName = "";
            img4.downloadedImgPath = "";
            img4.registeredImgName = "";
            img4.imgLocalPath = "";
            img4.parameter = "";

            imgStd.ctl = pic_std;
            imgStd.downloadedImgName = "";
            imgStd.downloadedImgPath = "";
            imgStd.registeredImgName = "";
            imgStd.imgLocalPath = "";
            imgStd.parameter = "";
            

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                txt_id.ReadOnly = true;

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_productCode.findByID(commonVar.DBconn, productID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    txt_id.Text = Convert.ToString(tempRow["jp_id"]);
                    txt_car.Text = Convert.ToString(tempRow["car"]);
                    txt_model.Text = Convert.ToString(tempRow["model"]);
                    txt_name.Text = Convert.ToString(tempRow["jp_name"]);
                    txt_num.Text = Convert.ToString(tempRow["jp_num"]);
                    txt_cavity.Text = Convert.ToString(tempRow["cavity"]);
                    txt_pkg.Value = Convert.ToDecimal(tempRow["qt_pkg"]);
                    txt_cycle.Value = Convert.ToDecimal(tempRow["cycle_t"]);
                    txt_mtrl.Text = Convert.ToString(tempRow["mtrl_num"]);
                    txt_spec.Text = Convert.ToString(tempRow["spec"]);
                    txt_mold.Text = Convert.ToString(tempRow["gh_id"]);
                    cbx_color.Color = Color.FromArgb(Convert.ToInt32(tempRow["jp_color"]));
                    txt_colorName.Text = Convert.ToString(tempRow["color_name"]);
                    txt_resin.Text = Convert.ToString(tempRow["sj_name"]);
                    txt_resin.Tag = Convert.ToString(tempRow["sj_id"]);

                    txt_write.Text = Convert.ToString(tempRow["wr_date"]);
                    txt_aprv.Text = Convert.ToString(tempRow["aprv_date"]);
                    txt_mass.Text = Convert.ToString(tempRow["mass_date"]);
                    txt_discont.Text = Convert.ToString(tempRow["discont_date"]);
                    txt_why.Text = Convert.ToString(tempRow["discont_why"]);
                    txt_optStock.Value = Convert.ToDecimal(tempRow["opt_stock"]);
                    txt_nowStock.Value = Convert.ToDecimal(tempRow["now_stock"]);
                    txt_memo.Text = Convert.ToString(tempRow["memo"]);

                    if ( Convert.ToString(tempRow["use_chk"]) == "Y" )
                        cbx_use.SelectedIndex = 0;
                    else
                        cbx_use.SelectedIndex = 1;


                    //이미지로딩
                    productImage[] images = new productImage[] { img1, img2, img3, img4, imgStd };
                    string[] paths = new string[] { 
                                                                Convert.ToString(tempRow["jp_img1"]), 
                                                                Convert.ToString(tempRow["jp_img2"]),
                                                                Convert.ToString(tempRow["jp_img3"]),
                                                                Convert.ToString(tempRow["jp_img4"]),                                                                
                                                                Convert.ToString(tempRow["jp_stdpaper"])
                                                                };
                    int i = 0;
                    foreach ( productImage myImage in images ) 
                    {                        
                        myImage.downloadedImgPath = paths[i];
                        if ( paths[i] == "no image" || paths[i].Length == 0)
                        {
                            myImage.ctl.Image = null;
                            myImage.downloadedImgPath = "";
                        }
                        else 
                        {
                            myImage.ctl.LoadAsync(paths[i]);
                            string filename = myImage.downloadedImgPath.Substring(myImage.downloadedImgPath.LastIndexOf("/") + 1);
                            myImage.downloadedImgName = filename;
                        }
                        i++;
                    }

                }
                else
                {
                    MessageBox.Show(Return.Message);
                }
            }//if
            if ( is_add == true ) //추가
            {
                clear();
                txt_id.ReadOnly = false;
                txt_id.Focus();
            }

            btn_save.Enabled = false;
            is_ValueChanged = false;
            is_loading = false;
        }

        private void ctl_productEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_productEdit_Load(this, e);
            else
                productCode.editCompleted();
        }




        private void btn_save_Click(object sender, EventArgs e)
        {
            if ( save() == true )
            {              

                DialogResult question;
                question = MessageBox.Show("등록에 성공했습니다. 추가 등록하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if ( question == DialogResult.Yes )
                {
                    is_add = true;
                    is_ValueChanged = false;
                    clear();
                    txt_id.ReadOnly = false;
                }
                else
                {
                    is_ValueChanged = false;
                    clear();
                    this.Hide();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("등록에 실패했습니다.");
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if ( is_ValueChanged == true )
            {
                DialogResult nRet;
                nRet = MessageBox.Show("변경된 자료가 있습니다. \n\r\n\r 저장할까요?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( nRet == DialogResult.Yes )   //Yes을 누르면                
                    btn_save.PerformClick();
                else if ( nRet == DialogResult.No )   //No을 누르면
                    is_ValueChanged = false;
            }

            is_ValueChanged = false;

            clear();
            this.Hide();
            this.Visible = false;

        }




        #region 함수

        public void setAddFlag(bool parentFlag) //추가-수정 구분할 때 사용하는 함수 (추가: is_add=true , 수정: is_add=false)
        {
            is_add = parentFlag;
            if ( is_add == true )
                clear();
        }

        public void setModeFlag(bool parentFlag2) //단순조회시 사용
        {
            is_read = parentFlag2;
        }

        public void readOnlyMode(bool flag) //단순조회시 컨트롤 속성 설정
        {
            if ( flag == true )
            {
                is_read = true;

                txt_id.ReadOnly = true;
                txt_car.ReadOnly = true;
                txt_model.ReadOnly = true;
                txt_name.ReadOnly = true;
                txt_num.ReadOnly = true;
                txt_cavity.ReadOnly = true;
                txt_pkg.ReadOnly = true;

                txt_cycle.ReadOnly = true;
                txt_mtrl.ReadOnly = true;
                txt_spec.ReadOnly = true;
                txt_mold.ReadOnly = true;
                cbx_color.ReadOnly = true;
                txt_colorName.ReadOnly = true;

                txt_resin.ReadOnly = true;
                txt_write.ReadOnly = true;
                txt_aprv.ReadOnly = true;
                txt_mass.ReadOnly = true;
                txt_discont.ReadOnly = true;
                txt_why.ReadOnly = true;
                txt_optStock.ReadOnly = true;
                txt_nowStock.ReadOnly = true;

                cbx_use.ReadOnly = true;
                txt_memo.ReadOnly = true;

                pic_img1.ReadOnly = true;
                pic_img2.ReadOnly = true;
                pic_img3.ReadOnly = true;
                pic_img4.ReadOnly = true;

                pic_std.ReadOnly = true;

                btn_picAdd1.Enabled = false;
                btn_picDel1.Enabled = false;

                btn_picAdd2.Enabled = false;
                btn_picDel2.Enabled = false;

                btn_picAdd3.Enabled = false;
                btn_picDel3.Enabled = false;

                btn_picAdd4.Enabled = false;
                btn_picDel4.Enabled = false;

                btn_picAddStd.Enabled = false;
                btn_picDelStd.Enabled = false;
            }
            else
            {
                is_read = false;

                if ( is_add == true )
                    txt_id.ReadOnly = false;
                else
                    txt_id.ReadOnly = true;

                txt_car.ReadOnly = false;
                txt_model.ReadOnly = false;
                txt_name.ReadOnly = false;
                txt_num.ReadOnly = false;
                txt_cavity.ReadOnly = false;
                txt_pkg.ReadOnly = false;

                txt_cycle.ReadOnly = false;
                txt_mtrl.ReadOnly = false;
                txt_spec.ReadOnly = false;
                txt_mold.ReadOnly = false;
                cbx_color.ReadOnly = false;
                txt_colorName.ReadOnly = false;

                txt_resin.ReadOnly = false;
                txt_write.ReadOnly = false;
                txt_aprv.ReadOnly = false;
                txt_mass.ReadOnly = false;
                txt_discont.ReadOnly = false;
                txt_why.ReadOnly = false;
                txt_optStock.ReadOnly = false;
                txt_nowStock.ReadOnly = false;

                cbx_use.ReadOnly = false;
                txt_memo.ReadOnly = false;

                pic_img1.ReadOnly = false;
                pic_img2.ReadOnly = false;
                pic_img3.ReadOnly = false;
                pic_img4.ReadOnly = false;
                pic_std.ReadOnly = false;

                btn_picAdd1.Enabled = true;
                btn_picDel1.Enabled = true;

                btn_picAdd2.Enabled = true;
                btn_picDel2.Enabled = true;

                btn_picAdd3.Enabled = true;
                btn_picDel3.Enabled = true;

                btn_picAdd4.Enabled = true;
                btn_picDel4.Enabled = true;

                btn_picAddStd.Enabled = true;
                btn_picDelStd.Enabled = true;
            }
        }


        public void setID(string parentID)
        {
            productID = parentID;
        }


        public void clear()
        {
            txt_id.Text = "";
            txt_car.Text = "";
            txt_model.Text = "";
            txt_name.Text = "";
            txt_num.Text = "";
            txt_pkg.Value = 0;
            txt_cavity.Text = txt_cavity.Properties.NullText;
            txt_cycle.Value = 0;
            txt_mtrl.Text = "";
            txt_spec.Text = txt_spec.Properties.NullText;
            txt_mold.Text = string.Empty;
            cbx_color.EditValue = null;
            txt_colorName.Text = "";

            txt_resin.Text = "";
            txt_resin.Tag = "";
            txt_write.Text = "";
            txt_aprv.Text = "";
            txt_mass.Text = "";
            txt_discont.Text = "";
            txt_why.Text = "";
            txt_optStock.Value = 0;
            txt_nowStock.Value = 0;
            cbx_use.SelectedIndex = 0;
            txt_memo.Text = "";        
            

            pic_img1.Image = null;
            pic_img2.Image = null;
            pic_img3.Image = null;
            pic_img4.Image = null;
            pic_std.Image = null;

            img1.downloadedImgName = "";
            img1.downloadedImgPath = "";
            img1.registeredImgName = "";
            img1.imgLocalPath = "";

            img2.downloadedImgName = "";
            img2.downloadedImgPath = "";
            img2.registeredImgName = "";
            img2.imgLocalPath = "";

            img3.downloadedImgName = "";
            img3.downloadedImgPath = "";
            img3.registeredImgName = "";
            img3.imgLocalPath = "";

            img4.downloadedImgName = "";
            img4.downloadedImgPath = "";
            img4.registeredImgName = "";
            img4.imgLocalPath = "";


            imgStd.downloadedImgName = "";
            imgStd.downloadedImgPath = "";
            imgStd.registeredImgName = "";
            imgStd.imgLocalPath = "";

            
            is_ValueChanged = false;

            setModeFlag(false);
        } //모든 컨트롤 내용 초기화

        private bool chkDuplicate() //중복항목 체크함수
        {

            commonReturn Return = new commonReturn();
            Return = fx_productCode.findByID(commonVar.DBconn, txt_id.Text);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private bool save() //저장버튼 누를 때 호출되는 함수
        {

            if ( txt_id.Text.Length == 0 )
            {
                MessageBox.Show("제품코드를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_name.Text.Length == 0 )
            {
                MessageBox.Show("제품이름을 입력하세요.", "주의");
                return false;
            }
            else if ( txt_num.Text.Length == 0 )
            {
                MessageBox.Show("제품번호를 입력하세요.", "주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("제품코드가 중복되었습니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();

                //제품코드 차종 모델 품명 품번 캐비티 포장수량 사이클타임 자재번호 사양 색상 색상명 등록일자 승인일자 양산일자 단종일자 단종사유 적정재고 사용여부 메모 이미지1,2,3,4
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@jp_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_id.Text.Trim());
                cmd.Parameters.Add("@car", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_car.Text);
                cmd.Parameters.Add("@model", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_model.Text);
                cmd.Parameters.Add("@jp_name", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_name.Text);
                cmd.Parameters.Add("@jp_num", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_num.Text);
                cmd.Parameters.Add("@cavity", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_cavity.Text);
                cmd.Parameters.Add("@cavity_num", SqlDbType.Int).Value = Convert.ToInt32(txt_cavity.Text.Substring(0, 2)); //작업지시에서 불러올 캐비티
                cmd.Parameters.Add("@qt_pkg", SqlDbType.Int).Value = Convert.ToDecimal(txt_pkg.Value);
                cmd.Parameters.Add("@cycle_t", SqlDbType.Money).Value = Convert.ToDecimal(txt_cycle.Value);
                cmd.Parameters.Add("@mtrl_num", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mtrl.Text);
                cmd.Parameters.Add("@spec", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_spec.Text);
                cmd.Parameters.Add("@gh_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mold.Text);
                cmd.Parameters.Add("@jp_color", SqlDbType.Int).Value = Convert.ToInt32(cbx_color.Color.ToArgb());
                cmd.Parameters.Add("@color_name", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_colorName.Text);
                cmd.Parameters.Add("@sj_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_resin.Tag);
                cmd.Parameters.Add("@wr_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_write.Text);
                cmd.Parameters.Add("@aprv_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_aprv.Text);
                cmd.Parameters.Add("@mass_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_mass.Text);
                cmd.Parameters.Add("@discont_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_discont.Text);
                cmd.Parameters.Add("@discont_why", SqlDbType.NVarChar, 100).Value = Convert.ToString(txt_why.Text);
                cmd.Parameters.Add("@opt_stock", SqlDbType.Money).Value = Convert.ToDecimal(txt_optStock.Value);
                cmd.Parameters.Add("@now_stock", SqlDbType.Money).Value = Convert.ToDecimal(txt_nowStock.Value);
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 100).Value = Convert.ToString(txt_memo.Text);
                cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_use.Text.Trim());

                //---------------------------------------------------------------------------------이미지 저장
                string imgEmpty = "no image";
                productImage[] pictureBoxes = new productImage[] { img1, img2, img3, img4, imgStd };
                foreach ( productImage singlePictureBox in pictureBoxes ) 
                {
                    if ( singlePictureBox.ctl.Image == null ) //컨트롤에 이미지 없을때 
                        singlePictureBox.parameter = imgEmpty;
                    else 
                    {
                        //컨트롤에 이미지가 있을때 path읽어오기
                        //기존경로가 존재하고 수정되지 않았을경우에는 원래 경로 저장
                        if ( (singlePictureBox.downloadedImgPath != "") && (singlePictureBox.registeredImgName == "") )
                            singlePictureBox.parameter = singlePictureBox.downloadedImgPath;
                    }

                    if ( !saveImg(singlePictureBox) ) 
                    {
                        MessageBox.Show("이미지 저장 실패","단일 이미지 저장");
                        return false;
                    }
                }
                //--------------------------------------------------------------------------------스칼라변수 설정
                cmd.Parameters.Add("jp_img1", SqlDbType.VarChar, 250).Value = img1.parameter;
                cmd.Parameters.Add("jp_img2", SqlDbType.VarChar, 250).Value = img2.parameter;
                cmd.Parameters.Add("jp_img3", SqlDbType.VarChar, 250).Value = img3.parameter;
                cmd.Parameters.Add("jp_img4", SqlDbType.VarChar, 250).Value = img4.parameter;
                cmd.Parameters.Add("jp_stdpaper", SqlDbType.VarChar, 250).Value = imgStd.parameter;


                commonReturn Return = new commonReturn();
                Return = fx_productCode.write(commonVar.DBconn, is_add, cmd);

                if ( Return.Message == "" )
                {   
                    return true;
                }
                else
                {
                    MessageBox.Show(Return.Message);
                    return false;
                }
            }
        }

        private void chkValueChanged(object sender, EventArgs e) //컨트롤 내 값의 변화를 감지
        {
            if ( !is_loading )
                is_ValueChanged = true;

            btn_save.Enabled = true;
        }

        #endregion



        #region 이미지 업/다운로드 관련 이벤트 및 함수       


        private bool saveImg(productImage pic) //사진 업로드 (ftp)
        {
            try
            {
                if ( !((pic.parameter == "no image") || (pic.registeredImgName == "")) )
                {
                    imgUploadHelper ftpClient = new imgUploadHelper(commonVar.userFTPServerIP, commonVar.userFTPID, commonVar.userFTPPassword);                  
                    string ftpFilePath = "JEPUM/" + txt_id.Text + "/" + pic.registeredImgName;
                    if ( ftpClient.Upload(pic.imgLocalPath, ftpFilePath) )
                    {
                        pic.parameter = imgDBpath + ftpFilePath;
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return true;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message + "\n\r 이미지 업로드에 실패했습니다.", "이미지 업로드 에러");
                return false;
            }

        }

        private void btn_picAdd_Click(object sender, EventArgs e) //로컬에서 사진 불러오기
        {
            string ctlName = ((SimpleButton)sender).Name;
            string filename = "";
            string local = "";
            PictureEdit pic = null;
            productImage singleImage=null;
            switch ( ctlName )
            {
                case "btn_picAdd1":
                    singleImage = img1;
                    pic = img1.ctl;
                    break;
                case "btn_picAdd2":
                    singleImage = img2;
                    pic = img2.ctl;
                    break;
                case "btn_picAdd3":
                    singleImage = img3;
                    pic = img3.ctl;
                    break;
                case "btn_picAdd4":
                    singleImage = img4;
                    pic = img4.ctl;
                    break;
                case "btn_picAddStd":
                    singleImage = imgStd;
                    pic = imgStd.ctl;
                    break;
            }

            if ( pic.Image != null )
            {
                MessageBox.Show("등록된 이미지가 있습니다. \n\r기존 이미지를 먼저 삭제 하세요.", "이미지 로드 에러");
            }
            else
            {
                pic.LoadImage();
                local = pic.GetLoadedImageLocation();
                filename = local.Substring(local.LastIndexOf("\\") + 1);
                singleImage.registeredImgName = filename;
                singleImage.imgLocalPath = local;

                chkValueChanged(this, e);
            }
        }

        private void btn_picDel_Click(object sender, EventArgs e)
        {
            string ctlName = ((SimpleButton)sender).Name;
            string imgName = "";
            PictureEdit pic = null ;
            productImage singleImage = null;
            switch ( ctlName ) 
            { 
                case "btn_picDel1":
                    pic = img1.ctl;
                    imgName = img1.downloadedImgName;
                    singleImage = img1;
                    break;
                case "btn_picDel2":
                    pic = img2.ctl;
                    imgName = img2.downloadedImgName;
                    singleImage = img2;
                    break;
                case "btn_picDel3":
                    pic = img3.ctl;
                    imgName = img3.downloadedImgName;
                    singleImage = img3;
                    break;
                case "btn_picDel4":
                    pic = img4.ctl;
                    imgName = img4.downloadedImgName;
                    singleImage = img4;
                    break;
                case "btn_picDelStd":
                    pic = imgStd.ctl;
                    imgName = imgStd.downloadedImgName;
                    singleImage = imgStd;
                    break;
            }

            if ( pic.Image == null )
            {
                MessageBox.Show("등록된 이미지가 없습니다. \n\r이미지를 먼저 등록 하세요.", "이미지 삭제 에러");
            }
            else
            {
                if ( (is_add == true) || (singleImage.downloadedImgPath == "") )
                {
                    pic.Image = null;
                }
                else
                {
                    if ( deleteImage(imgName) )
                    {
                        pic.Image = null; 
                        singleImage.imgLocalPath = "";
                        singleImage.registeredImgName = "";
                        singleImage.downloadedImgPath = "";
                        singleImage.downloadedImgName = "";
                        chkValueChanged(this, e);
                    }
                    else 
                    {
                        MessageBox.Show("이미지 삭제에 실패 했습니다.");
                    }                    
                }               

            }
        }

        private bool deleteImage(string imgName) 
        {
            imgUploadHelper ftpClient = new imgUploadHelper(commonVar.userFTPServerIP, commonVar.userFTPID, commonVar.userFTPPassword);
            string ftpFilePath = "JEPUM/" + txt_id.Text + "/" + imgName;
            if ( ftpClient.DeleteFile(ftpFilePath) )
            {
                return true;
            }
            else
                return false;
        }

        private void img_DoubleClick(object sender, EventArgs e)
        {
            if ( ((PictureEdit)sender).Image == null )
            {
                MessageBox.Show("사진이 존재하지 않습니다.", "에러");
            }
            else
            {
                frm_imageContainer imgContainer;
                int width = ((PictureEdit)sender).Image.Width;
                int height = ((PictureEdit)sender).Image.Height;

                string name = ((PictureEdit)sender).Name;
                string imgLocalPath = "";
                string downloadedImgPath = "";
                string description = "";

                switch ( name )
                {
                    case "pic_img1":
                        imgLocalPath = img1.imgLocalPath;
                        downloadedImgPath = img1.downloadedImgPath;
                        description = "제품사진(1)";
                        break;
                    case "pic_img2":
                        imgLocalPath = img2.imgLocalPath;
                        downloadedImgPath = img2.downloadedImgPath;
                        description = "제품사진(2)";
                        break;
                    case "pic_img3":
                        imgLocalPath = img3.imgLocalPath;
                        downloadedImgPath = img3.downloadedImgPath;
                        description = "제품사진(3)";
                        break;
                    case "pic_img4":
                        imgLocalPath = img4.imgLocalPath;
                        downloadedImgPath = img4.downloadedImgPath;
                        description = "제품사진(4)";
                        break;
                    case "pic_std":
                        imgLocalPath = imgStd.imgLocalPath;
                        downloadedImgPath = imgStd.downloadedImgPath;
                        description = txt_name.Text + " 작업표준서";
                        break;
                }
                if ( imgLocalPath != "" )
                    imgContainer = new frm_imageContainer(width, height, imgLocalPath, description);
                else
                    imgContainer = new frm_imageContainer(width, height, downloadedImgPath, description);

                imgContainer.ShowDialog();
            }
        }
        #endregion

        private void ResinReference(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_resinRef resinRef = new frm_resinRef();
            resinRef.SendResinInfoEvent += new frm_resinRef.SendResinDataHandler(ResinInfo);
            resinRef.ShowDialog();

            bgimg.Visible = false;
        }

        private void ResinInfo(frm_resinRef.resinInformation selectedResinInfo)
        {
            txt_resin.Text = selectedResinInfo.resinName;
            txt_resin.Tag = selectedResinInfo.resinID;
        }

        private void txt_mold_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_moldRef moldRef = new frm_moldRef();
            moldRef.SendMoldInfoEvent += new frm_moldRef.SendMoldDataHandler(setMoldInfo);
            moldRef.ShowDialog();

            bgimg.Visible = false;
        }

        private void setMoldInfo(frm_moldRef.moldInformation selectedMoldInfo)
        {
            txt_mold.Text = selectedMoldInfo.moldID;
        }


    }//class
}//namespace
