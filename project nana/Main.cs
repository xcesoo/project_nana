namespace project_nana
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            import_telegram_json.Click += (a, e) => ChangeForm(new TelegramForm());
            import_txt.Click += (a, e) => ChangeForm(new TextForm());
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

        //Переміщення форми (кінець)


        // Відкриття гілки Import
        private void import_btn_Click(object sender, EventArgs e) => sub_menu_import.Visible = sub_menu_import.Visible ? false : true;

        // Відкриття гілки Export
        private void export_btn_Click(object sender, EventArgs e) => sub_menu_export.Visible = sub_menu_export.Visible ? false : true;

        private void form_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скидуємось мені на відяху -> 5375 4114 2761 5013", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Змінюємо форму залежно що обрали Text - Json
        private Form _active;
        private void ChangeForm(Form form)
        {
            if (_active != null) _active.Close();
            _active = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            main_panel.Controls.Add(form);
            main_panel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void minimize_button_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized; // Згорнути програму

        private void close_button_Click(object sender, EventArgs e) => Application.Exit(); // Вихід з програми

        Info mboxInfo;
        private void info_Click(object sender, EventArgs e)
        {
            if(mboxInfo == null || mboxInfo.IsDisposed) mboxInfo = new Info();
            mboxInfo.BringToFront();
            mboxInfo.Show();
        }
    }
}
