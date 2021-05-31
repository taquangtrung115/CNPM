using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using frmMain.GUI;
using DAL;
namespace frmMain
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DangNhapDAL dn = new DangNhapDAL();
        public frmMain()
        {
            InitializeComponent();
            
        }
        private static string chucVu;

        public static string ChucVu { get => chucVu; set => chucVu = value; }

        public frmMain(string chucvu)
        {
            InitializeComponent();

            ChucVu = chucvu;
            if (ChucVu == "Bác sĩ")
            {
              btnXetNghiem.Enabled= btnViTri.Enabled=  btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnDatHang.Enabled = btnBanThuoc.Enabled = btnNhapHang.Enabled = btnTiepNhan.Enabled = btnThuNgan.Enabled = btnLayThuoc.Enabled = false;
            }
            else if (ChucVu == "Xét nghiệm")
            {
              btnDaKhoa.Enabled= btnViTri.Enabled=  btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnDatHang.Enabled = btnBanThuoc.Enabled = btnNhapHang.Enabled = btnTiepNhan.Enabled = btnThuNgan.Enabled = btnLayThuoc.Enabled = btnKhamBenh.Enabled = false;
            }
            else if (ChucVu == "Thu ngân")
            {
               btnViTri.Enabled= btnXetNghiem.Enabled= btnDaKhoa.Enabled= btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnDatHang.Enabled = btnBanThuoc.Enabled = btnNhapHang.Enabled = btnTiepNhan.Enabled = btnLayThuoc.Enabled = btnKhamBenh.Enabled = false;
            }
            else if(ChucVu == "Kho")
            {
               btnDaKhoa.Enabled = btnViTri.Enabled= btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnBanThuoc.Enabled = btnTiepNhan.Enabled = btnThuNgan.Enabled = btnLayThuoc.Enabled = btnKhamBenh.Enabled = btnXetNghiem.Enabled = false;
            }
            else if (ChucVu == "Tiếp nhận")
            {
              btnDatHang.Enabled= btnNhapHang.Enabled=  btnDaKhoa.Enabled = btnViTri.Enabled = btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnBanThuoc.Enabled = btnThuNgan.Enabled = btnLayThuoc.Enabled = btnKhamBenh.Enabled = btnXetNghiem.Enabled = false;
            }
        }
        //private NhanVienModel acc;

        //public NhanVienModel Acc
        //{
        //    get { return acc; }
        //    set { acc = value; phanQuyen(Acc.ChucVu); }
        //}
        //void phanQuyen(string loaiTK)
        //{
        //    if (loaiTK == "bác sĩ")
        //    {
        //        btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnDatHang.Enabled = btnBanThuoc.Enabled = btnNhapHang.Enabled = btnTiepNhan.Enabled = btnThuNgan.Enabled = btnLayThuoc.Enabled = false;
        //    }
        //    else if (loaiTK == "xét nghiệm")
        //    {
        //        btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnDatHang.Enabled = btnBanThuoc.Enabled = btnNhapHang.Enabled = btnTiepNhan.Enabled = btnThuNgan.Enabled = btnLayThuoc.Enabled = btnKhamBenh.Enabled= false;
        //    }
        //    else if(loaiTK == "thu ngân")
        //    {
        //        btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnDatHang.Enabled = btnBanThuoc.Enabled = btnNhapHang.Enabled = btnTiepNhan.Enabled  = btnLayThuoc.Enabled = btnKhamBenh.Enabled = false;
        //    }
        //    else if (loaiTK == "kho")
        //    {
        //        btnNhanVien.Enabled = btnNhaCC.Enabled = btnLoaiThuoc.Enabled = btnThuoc.Enabled = btnDatHang.Enabled = btnBanThuoc.Enabled = btnNhapHang.Enabled = btnTiepNhan.Enabled = btnThuNgan.Enabled = btnLayThuoc.Enabled = btnKhamBenh.Enabled = btnXetNghiem.Enabled= false;
        //    }

        //}
        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Visual Studio 2013 Light";

            Form frm = this.checkExit(typeof(frmMedical));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMedical staff = new frmMedical();
                staff.MdiParent = this;
                staff.Show();
            }
        }
        private Form checkExit(Type type)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == type)
                {
                    return item;
                }
            }
            return null;
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmStaff2));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmStaff2 staff = new frmStaff2();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnNhaCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmSupplier));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSupplier staff = new frmSupplier();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnLoaiThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCategory staff = new frmCategory();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmMedicine));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMedicine staff = new frmMedicine();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmSellMedicine));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSellMedicine staff = new frmSellMedicine();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnViTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmLocation));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLocation staff = new frmLocation();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmOrder));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmOrder staff = new frmOrder();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnKhamBenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmMedical));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMedical staff = new frmMedical();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmStaffNursing));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmStaffNursing staff = new frmStaffNursing();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnDaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmPolyclinic));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPolyclinic staff = new frmPolyclinic();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnThuNgan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmCashier));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCashier staff = new frmCashier();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnXetNghiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmTest));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTest staff = new frmTest();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void btnLayThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmDrugDelivery));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDrugDelivery staff = new frmDrugDelivery();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExit(typeof(frmImportMedicine));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmImportMedicine staff = new frmImportMedicine();
                staff.MdiParent = this;
                staff.Show();
            }
        }
    }
}
