namespace project_nana
{
    public partial class Main : Form
    {
        private TelegramForm TgFrom = new TelegramForm();
        private TextForm TxtFrom = new TextForm();
        private string LoadedFileJson = string.Empty;
        private List<string> LoadedFileTxt = new List<string>();
        public Main()
        {
            InitializeComponent();
            import_telegram_json.Click += (a, e) =>
            {
                ChangeForm(TgFrom);
                string filePath = LoadFile("Json Files|*.json");
                if (filePath != string.Empty)
                {
                    LoadedFileJson = File.ReadAllText(filePath);
                    TgFrom.TakeStat(LoadedFileJson);
                }
            };
            import_txt.Click += (a, e) =>
            {
                ChangeForm(TxtFrom);
                string filePath = LoadFile("Text Files|*.txt");
                if (filePath != string.Empty)
                {
                    LoadedFileTxt.AddRange(File.ReadAllLines(filePath));
                    TxtFrom.TakeStat(LoadedFileTxt);
                }
            };
        }
        private string LoadFile(string fileType)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.FileName = string.Empty;
                openFileDialog.Filter = fileType;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return "";
        }

        //���������� ����� (�������)
        private bool FormDragged = false;                                            // ����� ��������� �� border panel
        private Point StartMousePosition;                                      // �������� ������� ���������� �����
        private void border_panel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragged = true;                                                    // ����� ���������
            StartMousePosition = e.Location;                                   // ���� �������� �������
        }

        private void border_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormDragged)                                                       // ���� ����� ���������
            {                                                                   //
                Point screenPoint = PointToScreen(e.Location);                  // ������������ ������� ���������� ����� � �������� ������ ����������
                Location = new Point                                            // 
                    (screenPoint.X - StartMousePosition.X,                       // ������� Location �����
                    screenPoint.Y - StartMousePosition.Y);                       //
            }
        }

        private void border_panel_MouseUp(object sender, MouseEventArgs e) => FormDragged = false;  // ������� ���� ���� _dragged

        //���������� ����� (�����)

        // ³������� ���� Import
        private void import_btn_Click(object sender, EventArgs e) => sub_menu_import.Visible = sub_menu_import.Visible ? false : true;

        private void form_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� ��� �� ����� -> 5375 4114 2761 5013", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ������� ����� ������� �� ������ Text - Json
        public Form ActiveForm;
        private void ChangeForm(Form form)
        {
            if (ActiveForm == form) return;
            if (ActiveForm != null) ActiveForm.Hide();
            ActiveForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            main_panel.Controls.Add(form);
            main_panel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void minimize_button_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized; // �������� ��������

        private void close_button_Click(object sender, EventArgs e) => Application.Exit(); // ����� � ��������

        private Info MboxInfo;
        private void info_Click(object sender, EventArgs e)
        {
            if (MboxInfo == null || MboxInfo.IsDisposed) MboxInfo = new Info();
            MboxInfo.BringToFront();
            MboxInfo.Show();
        }
    }
}
