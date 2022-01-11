using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIDBFramwork.Windows
{
    public class JIMessageBox
    {
        public static void ShowErrorMessage(String message)
        {
            MessageBox.Show(message ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorMessage(String message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public static void ShowSuccessMessage(String message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowSuccessMessage(String message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
