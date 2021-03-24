using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAssignment
{
    public partial class fLogin : Form
    {
        string name = "buitrongtin";
        string pass = "1";
        int count = 0;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == name && txtPass.Text == pass)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công");
                this.Close();
                
                try
                {
                    fMain f = (fMain)this.Owner;
                    f.mnuSearch.Enabled = true;
                    f.mnuInputData.Enabled = true;
                }
                catch { }
                

            }
            else
            {
                count++;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            if (count >= 3)
            {
                MessageBox.Show("Nhập sai quá 3 lần");
                Application.Exit();
            }
                
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận điều hướng", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
