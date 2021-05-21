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
    public partial class frmMedical : DevExpress.XtraEditors.XtraForm
    {
        public frmMedical()
        {
            InitializeComponent();
        }

        private void frmMedical_Load(object sender, EventArgs e)
        {

        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //Các nút thêm, xóa, sửa...
            if (e.Button.Properties.Caption == "Đ.K Khám")
            {

            }
            else if (e.Button.Properties.Caption == "Tìm BN")
            {
                //Sử dụng LookupEdit
                //cbMaKhoa.Properties.DataSource = ...;
                //cbMaKhoa.Properties.ValueMember = "MaDM";
                //cbMaKhoa.Properties.DisplayMember = "TenDM";
                //cbMaKhoa.ItemIndex = 0;
            }
            else if (e.Button.Properties.Caption == "Xem Phòng")
            {

            }
            else if (e.Button.Properties.Caption == "In Phiếu")
            {


            }
            else if (e.Button.Properties.Caption == "DS Bệnh Nhân")
            {

            }
            else if (e.Button.Properties.Caption == "Thoát")
            {


            }
        }
    }
}