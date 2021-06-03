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
    public partial class frmMedicalBill : DevExpress.XtraEditors.XtraForm
    {
        NhanVienDAL nv = new NhanVienDAL();
        BangGiaKhamBenhDAL bgkb = new BangGiaKhamBenhDAL();
        PhieuKhamBenhDAL pkb = new PhieuKhamBenhDAL();
        BindingSource dspkb = new BindingSource();
        BenhNhanDAL bn = new BenhNhanDAL();
        PhongDieuTri_HuyDAL pdt = new PhongDieuTri_HuyDAL();
        public frmMedicalBill()
        {
            InitializeComponent();
        }

        private void frmMedicalBill_Load(object sender, EventArgs e)
        {
            try
            {
                txtNhanVien.Text = layTTNV().Rows[0].ItemArray[1].ToString();
            }
            catch (Exception)
            {
                txtNhanVien.Text = "Loi";

            }
            comBoBox_PhongDieuTri();
            comBoBox_TrangThai();
            comBoBox_BangGiaKhamBenh();
            txtNgayLap.Text = DateTime.Now.ToShortDateString();
            txtTenBN.Text = frmStaffNursing.BenhNhanTiepNhan.tenBenhNhan;
            pkb.load_PhieuKhamBenh();
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tải Lại")
            {

            }

        }





        ////////////////////////Ham///////////
        void comBoBox_TrangThai()
        {
            DataTable dtblDataSource = new DataTable();
            dtblDataSource.Columns.Add("MaTrangThai");
            dtblDataSource.Columns.Add("TenTrangThai");

            dtblDataSource.Rows.Add("ChoThucHien", "Chờ Thực Hiện");
            dtblDataSource.Rows.Add("ChuaThucHien", "Chưa Thực Hiện");


            cbTrangThai.Properties.DisplayMember = "TenTrangThai";
            cbTrangThai.Properties.ValueMember = "MaTrangThai";
            cbTrangThai.Properties.DataSource = dtblDataSource;
            cbTrangThai.ItemIndex = 0;
        }
        void comBoBox_BangGiaKhamBenh() {
            cbHinhThucKham.Properties.DisplayMember = "HINHTHUCKHAM";
            cbHinhThucKham.Properties.ValueMember = "MAGIAKHAM";
            cbHinhThucKham.Properties.DataSource = bgkb.load_BangGiaKhamBenh();
            cbHinhThucKham.ItemIndex = 0;
        }
        void comBoBox_PhongDieuTri()
        {
            cbPhong.Properties.DisplayMember = "TENPHONG";
            cbPhong.Properties.ValueMember = "MAPHONG";
            cbPhong.Properties.DataSource = pdt.load_cbPhongDieuTri();
            cbPhong.ItemIndex = 0;
        }
        void themPhieuKhamBenh() {
            Random rd = new Random();
            int maPKB = rd.Next(1, 10000);
            try
            {
                pkb.them(maPKB, bn.layMaBenhNhan(frmStaffNursing.BenhNhanTiepNhan.tenBenhNhan, frmStaffNursing.BenhNhanTiepNhan.diaChi), layTTNV().Rows[0].ItemArray[0].ToString(), txtNgayLap.DateTime.Date.ToShortDateString(), cbPhong.EditValue.ToString(), txtTinhTrangSK.Text, txtDeNghiKham.Text, cbHinhThucKham.EditValue.ToString(), cbTrangThai.EditValue.ToString());
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thêm thất bại - Lỗi: " + ex.Message.ToString());

            }
        }
        DataTable layTTNV() {
            return nv.layTTNhanVien(frmLogin.ControlID.textData.ToString());
        }
        void load_PhieuKhamBenh() {
            
            dspkb.DataSource = pkb.load_PhieuKhamBenh();

            ReportDAL hd = new ReportDAL();
            //private void btnChoKham_Click(object sender, EventArgs e)
            //{
            //    //rpKhamBenh rphd = new rpKhamBenh();
            //    //int mabn = int.Parse(cbTenBenhNhan.EditValue.ToString());
            //    //rphd.DataSource = hd.phieuKhamBenh(mabn);
            //    //rphd.ShowPreviewDialog();

            //}
        }

        private void btnChoKham_Click(object sender, EventArgs e)
        {
            themPhieuKhamBenh();
            rpKhamBenh a = new rpKhamBenh();
            a.DataSource = pkb.loadPhieuKhamBenh(bn.layMaBenhNhan(frmStaffNursing.BenhNhanTiepNhan.tenBenhNhan,frmStaffNursing.BenhNhanTiepNhan.diaChi));
            ReportPrintTool tool = new ReportPrintTool(a);
            a.ShowPreviewDialog();
        }
    }
}