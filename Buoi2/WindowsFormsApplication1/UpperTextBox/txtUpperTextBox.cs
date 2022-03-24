using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpperTextBox
{
    public class txtUpperTextBox:TextBox
    {
        public txtUpperTextBox()
        {
            this.KeyPress += txtUpperTextBox_KeyPress;
        }

        void txtUpperTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
