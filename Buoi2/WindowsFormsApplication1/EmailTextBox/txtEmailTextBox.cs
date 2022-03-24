using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTextBox
{
    public class txtEmailTextBox : TextBox
    {
        public txtEmailTextBox()
        {
            this.KeyPress += txtEmailTextBox_KeyPress;
        }

        void txtEmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = "@";
            if (!txtEmailTextBox.Contains(a) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
