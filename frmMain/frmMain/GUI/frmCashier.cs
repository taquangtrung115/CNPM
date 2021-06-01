using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using DevExpress.XtraReports.UI;
namespace frmMain.GUI
{
    public partial class frmCashier : DevExpress.XtraEditors.XtraForm
    {
        public frmCashier()
        {
            InitializeComponent();
        }
        
        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //Các nút thêm, xóa, sửa...
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                //Sử dụng LookupEdit
                //cbMaKhoa.Properties.DataSource = ...;
                //cbMaKhoa.Properties.ValueMember = "MaDM";
                //cbMaKhoa.Properties.DisplayMember = "TenDM";
                //cbMaKhoa.ItemIndex = 0;
            }
            else if (e.Button.Properties.Caption == "Thống Kê Bệnh Nhân")
            {
                rpBenhNhan a = new rpBenhNhan();
                a.ShowPreviewDialog();
            }
            else if (e.Button.Properties.Caption == "Thống Kê Doanh Thu")
            {


            }
            else if (e.Button.Properties.Caption == "Bệnh Nhân Đã Thanh Toán")
            {

            }

           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {

        }
    }
}