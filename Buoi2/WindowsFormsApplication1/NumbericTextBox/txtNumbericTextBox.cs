using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbericTextBox
{
    public class txtNumbericTextBox:TextBox
    {
        public txtNumbericTextBox()
        {
            this.KeyPress += txtNumbericTextBox_KeyPress;
        }

        void txtNumbericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
