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



namespace frmMain.GUI
{
    public partial class frmStaffNursing : DevExpress.XtraEditors.XtraForm
    {

        BenhNhanDAL bn = new BenhNhanDAL();
        BindingSource dsBN = new BindingSource();
        public static class BenhNhanTiepNhan
        {
            public static string tenBenhNhan { get; set; }
            public static string diaChi { get; set; }
        }
        public frmStaffNursing()
        {
            InitializeComponent();
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //Các nút thêm, xóa, sửa...
            if (e.Button.Properties.Caption == "Tải Lại")
            {

            }
            else if (e.Button.Properties.Caption == "Xuất Word")
            {
                //Sử dụng LookupEdit
                //cbMaKhoa.Properties.DataSource = ...;
                //cbMaKhoa.Properties.ValueMember = "MaDM";
                //cbMaKhoa.Properties.DisplayMember = "TenDM";
                //cbMaKhoa.ItemIndex = 0;
            }
            else if (e.Button.Properties.Caption == "Xuất Excel")
            {

            }


        }



        private void frmStaffNursing_Load(object sender, EventArgs e)
        {

            txtNgaySinh.Text = DateTime.Now.ToShortDateString();
            comBoBox_GioiTinh();

            bn.loadGripView();



        }

        /// <summary>
        /// ///////////////////
        /// </summary>
        void comBoBox_GioiTinh()
        {
            DataTable dtblDataSource = new DataTable();
            dtblDataSource.Columns.Add("Text");
            dtblDataSource.Columns.Add("Value");

            dtblDataSource.Rows.Add("Nam", "Nam");
            dtblDataSource.Rows.Add("Nu", "Nu");


            cbGioiTinh.Properties.DisplayMember = "Value";
            cbGioiTinh.Properties.ValueMember = "Text";
            cbGioiTinh.Properties.DataSource = dtblDataSource;
            cbGioiTinh.ItemIndex = 0;
        }
       
       

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            themBenhNhan();
         
            BenhNhanTiepNhan.tenBenhNhan= txtTenBN.Text.ToString();
           BenhNhanTiepNhan.diaChi=  txtDiaChi.Text.ToString();
            frmMedicalBill form = new frmMedicalBill();
            form.Show();
            ////////////truyen du lieu///////////

        }
        void themBenhNhan()
        { Random rd = new Random();
        int mabenhNhan = rd.Next(1, 10000);
            try
            {
                bn.them(mabenhNhan, txtTenBN.Text, txtNgaySinh.DateTime.Date.ToShortDateString(), cbGioiTinh.EditValue.ToString(), txtDiaChi.Text, txtSDT.Text);
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thêm thất bại - Lỗi: " + ex.Message.ToString());

            }
        }

       
    }
}