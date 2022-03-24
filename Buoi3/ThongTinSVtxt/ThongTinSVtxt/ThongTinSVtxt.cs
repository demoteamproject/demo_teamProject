using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ThongTinSVtxt
{
    public partial class ThongTinSVtxt: UserControl
    {
        public ThongTinSVtxt()
        {
            InitializeComponent();
        }

        private void ThongTinSVtxt_Load(object sender, EventArgs e)
        {

        }

        private void buttonNhap_Click(object sender, EventArgs e)
        {
            nhapMaSV();
        }

        private void textMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nhapMaSV();
            }
        }

        private void textMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhapMaSV()
        {
            System.IO.StreamReader txt = new System.IO.StreamReader("E:/LuuDuLieuSinhVien/TranGiaPhuc/Buoi3/SinhVien.txt");
            string line;

            while ((line = txt.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                if (textMaSV.Text == temp[0])
                {
                    textTenSV.Text = temp[1];
                    textMaLop.Text = temp[2];
                    textNgaySinh.Text = temp[3];
                    textGioiTinh.Text = temp[4];
                    textCMND.Text = temp[5];
                    return;
                }
                MessageBox.Show("Mã SV không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txt.Close();
        }
    }
}
