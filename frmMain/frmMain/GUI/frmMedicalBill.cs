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
        public frmMedicalBill()
        {
            InitializeComponent();
        }

        private void frmMedicalBill_Load(object sender, EventArgs e)
        {

        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tải Lại")
            {
                
            }
            
        }
        ReportDAL hd = new ReportDAL();
        private void btnChoKham_Click(object sender, EventArgs e)
        {
            rpKhamBenh rphd = new rpKhamBenh();
            int mabn = int.Parse(cbTenBenhNhan.EditValue.ToString());
            rphd.DataSource = hd.phieuKhamBenh(mabn);
            rphd.ShowPreviewDialog();
        }
    }
}