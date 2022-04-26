using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupAndRestoreSQL
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            tbxServername.Text = "DESKTOP-JMVQLI9".Trim();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxServername.Text.Trim() == "")
            {
                MessageBox.Show("Server name không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                tbxServername.Focus();
                return;
            }
            else if (tbxUsername.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                tbxUsername.Focus();
                return;
            }
            else if (tbxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                tbxPassword.Focus();
                return;
            }
            else
            {
                Program.login = tbxUsername.Text;
                Program.password = tbxPassword.Text;
                Program.servername = tbxServername.Text;
                if (Program.ketNoiDB() == 0) return;
                MessageBox.Show("Đăng nhập thành công", "Successful", MessageBoxButtons.OK);
                this.Hide();
                Program.fmMain.Show();
            }
        }


    }
}
