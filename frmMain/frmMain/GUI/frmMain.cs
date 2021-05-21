﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using frmMain.GUI;
namespace frmMain
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

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
    }
}
