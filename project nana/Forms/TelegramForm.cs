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
        ChatAnalyzer chatAnalyzer = new ChatAnalyzer();
        DataChat chat;
        public TelegramForm()
        {
            InitializeComponent();
        }
        private async Task DisplayTelegramStat()
        {
            //Task Listbox1 = Task.Run(() => takestat());
            //await Task.WhenAll(Listbox1);
        }
    }
}
