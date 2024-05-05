using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_nana
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        //Переміщення форми (початок)
        private bool _dragged = false;                                            // Мишка натиснута на border panel
        private Point _startMousePosition;                                      // Стартова позиція натискання мишки
        private void border_panel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragged = true;                                                    // Мишка натиснута
            _startMousePosition = e.Location;                                   // Зміна стартової позиції
        }

        private void border_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragged)                                                       // Якщо мишка натиснута
            {                                                                   //
                Point screenPoint = PointToScreen(e.Location);                  // Перетворюємо локальні координати форми у глобальні екранні координати
                Location = new Point                                            // 
                    (screenPoint.X - _startMousePosition.X,                       // Змінюємо Location форми
                    screenPoint.Y - _startMousePosition.Y);                       //
            }
        }

        private void border_panel_MouseUp(object sender, MouseEventArgs e) => _dragged = false;  // Змінюємо стан поля _dragged

        private void import_btn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //Переміщення форми (кінець)
    }
}
