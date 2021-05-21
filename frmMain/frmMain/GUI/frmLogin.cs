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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMain b = new frmMain();
            this.Hide();
            b.ShowDialog();

            this.Show();
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