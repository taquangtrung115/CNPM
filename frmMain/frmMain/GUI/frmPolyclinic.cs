using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace frmMain.GUI
{
    public partial class frmPolyclinic : DevExpress.XtraEditors.XtraForm
    {
        public frmPolyclinic()
        {
            InitializeComponent();
        }

        private void groupControl4_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //Các nút thêm, xóa, sửa...
            if (e.Button.Properties.Caption == "Nhập")
            {
                //Sử dụng LookupEdit
                //cbMaKhoa.Properties.DataSource = ...;
                //cbMaKhoa.Properties.ValueMember = "MaDM";
                //cbMaKhoa.Properties.DisplayMember = "TenDM";
                //cbMaKhoa.ItemIndex = 0;
            }
            else if (e.Button.Properties.Caption == "In Phiếu")
            {

            }
            else if (e.Button.Properties.Caption == "Xóa")
            {


            }
            else if (e.Button.Properties.Caption == "Sửa")
            {

            }
            
            else if (e.Button.Properties.Caption == "Yêu Cầu Xét Nghiệm")
            {


            }
        }

        private void groupControl5_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //Chi tiết kê toa
            //Các nút thêm, xóa, sửa...
            if (e.Button.Properties.Caption == "Nhập")
            {
                //Sử dụng LookupEdit
                //cbMaKhoa.Properties.DataSource = ...;
                //cbMaKhoa.Properties.ValueMember = "MaDM";
                //cbMaKhoa.Properties.DisplayMember = "TenDM";
                //cbMaKhoa.ItemIndex = 0;
            }
            else if (e.Button.Properties.Caption == "In Phiếu")
            {

            }
            else if (e.Button.Properties.Caption == "Xóa")
            {


            }
            else if (e.Button.Properties.Caption == "Sửa")
            {

            }

            else if (e.Button.Properties.Caption == "Yêu Cầu Xét Nghiệm")
            {


            }
        }
    }
}