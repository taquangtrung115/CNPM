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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static class ControlID
        {
            public static string textData{ get; set; }
        }
        public static string chucVu = "";
        DangNhapDAL dn = new DangNhapDAL();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dn.dangNhap(txtUsername.Text.Trim(), txtPassword.Text.Trim()) == true)
            {
               
                frmMain b = new frmMain(dn.layCHucVu(txtUsername.Text,txtPassword.Text).ToString());
                ControlID.textData = txtUsername.Text;
                this.Hide();
                b.ShowDialog();

                this.Show();
            }
            else
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            txtPassword.Properties.UseSystemPasswordChar = true;
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Visual Studio 2013 Light";
        }

        private void ckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPassword.Checked == true)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}