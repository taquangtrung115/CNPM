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
    public partial class frmOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //Các nút thêm, xóa, sửa...
            if (e.Button.Properties.Caption == "Thêm")
            {
                //Sử dụng LookupEdit
                //cbMaKhoa.Properties.DataSource = ...;
                //cbMaKhoa.Properties.ValueMember = "MaDM";
                //cbMaKhoa.Properties.DisplayMember = "TenDM";
                //cbMaKhoa.ItemIndex = 0;
            }
            else if (e.Button.Properties.Caption == "Lưu")
            {

            }
            else if (e.Button.Properties.Caption == "Xóa")
            {


            }
            else if (e.Button.Properties.Caption == "Sửa")
            {

            }
            else if (e.Button.Properties.Caption == "Tìm")
            {


            }
        }
    }
}