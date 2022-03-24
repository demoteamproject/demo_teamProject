using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeLogin
{
    public partial class ThietKeLogin: UserControl
    {
        public ThietKeLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty)
                MessageBox.Show("Tên đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK);
            else if (txtPassword.Text == string.Empty)
                MessageBox.Show("Mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK);
            return;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Parent.Dispose();
        }
    }
}
