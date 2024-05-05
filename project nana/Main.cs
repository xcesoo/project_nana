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

        //���������� ����� (�������)
        private bool _dragged = false;                                            // ����� ��������� �� border panel
        private Point _startMousePosition;                                      // �������� ������� ���������� �����
        private void border_panel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragged = true;                                                    // ����� ���������
            _startMousePosition = e.Location;                                   // ���� �������� �������
        }

        private void border_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragged)                                                       // ���� ����� ���������
            {                                                                   //
                Point screenPoint = PointToScreen(e.Location);                  // ������������ ������� ���������� ����� � �������� ������ ����������
                Location = new Point                                            // 
                    (screenPoint.X - _startMousePosition.X,                       // ������� Location �����
                    screenPoint.Y - _startMousePosition.Y);                       //
            }
        }

        private void border_panel_MouseUp(object sender, MouseEventArgs e) => _dragged = false;  // ������� ���� ���� _dragged

        //���������� ����� (�����)


        // ³������� ���� Import
        private void import_btn_Click(object sender, EventArgs e) => sub_menu_import.Visible = sub_menu_import.Visible ? false : true;

        // ³������� ���� Export
        private void export_btn_Click(object sender, EventArgs e) => sub_menu_export.Visible = sub_menu_export.Visible ? false : true;

        private void form_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� ��� �� ����� -> 5375 4114 2761 5013", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ������� ����� ������� �� ������ Text - Json
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

        private void minimize_button_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized; // �������� ��������

        private void close_button_Click(object sender, EventArgs e) => Application.Exit(); // ����� � ��������

        Info mboxInfo;
        private void info_Click(object sender, EventArgs e)
        {
            if(mboxInfo == null || mboxInfo.IsDisposed) mboxInfo = new Info();
            mboxInfo.BringToFront();
            mboxInfo.Show();
        }
    }
}
