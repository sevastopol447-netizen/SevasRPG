using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevasRPG.Utils
{
    public class MessageHelper
    {
        public static void levelUpMessage(int level)
        {
            MessageBox.Show($"Вітаю, ви отримали {level} рівень", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}