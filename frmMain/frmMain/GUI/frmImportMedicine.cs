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
    public partial class frmImportMedicine : DevExpress.XtraEditors.XtraForm
    {
        public frmImportMedicine()
        {
            InitializeComponent();
        }
        ReportDAL rp = new ReportDAL();
        private void btnThem_Click(object sender, EventArgs e)
        {
            rpNhapHang a = new rpNhapHang();
            string b = "1";
            a.DataSource = rp.datHang(b);
            a.ShowPreviewDialog();
        }
    }
}