using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_nana
{
    public partial class TelegramForm : Form
    {
        public TelegramForm()
        {
            InitializeComponent();
        }
        private void telegram_stat_textbox_MouseWheel(object sender, MouseEventArgs e)
        {
            int linesToScroll = e.Delta * 3 / 120;
        }
    }
}
