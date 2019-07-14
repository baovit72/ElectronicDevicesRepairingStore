using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GUI_QuanLy
{
    class GUIUtility
    {
        public static void HandleDigitTextBox(object sender, ref KeyPressEventArgs e)
        {
            //Chi cho nhap so
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public static bool PromptConfirmDelete()
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá yêu cầu này ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return true;
            else
                return false;

        }
    }
}
