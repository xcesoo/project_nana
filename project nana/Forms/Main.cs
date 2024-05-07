using System.Diagnostics;

namespace project_nana
{
    public partial class Main : Form
    {
        string file = string.Empty;
        ChatAnalyzer chatAnalyzer = new ChatAnalyzer();
        TextAnalyzer textAnalyzer = new TextAnalyzer();
        DataChat chat;
        public Main()
        {
            InitializeComponent();
            import_telegram_json.Click += (a, e) =>
            {
                ChangeForm(new TelegramForm());
                LoadFile("Json Files|*.json");
                try
                {
                    chat = DataChatSet.CreateNewDataChat(file);
                    var result = chatAnalyzer.Analyze(chat);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };

            import_txt.Click += (a, e) =>
            {
                ChangeForm(new TextForm());
            };
        }

        private int LoadFile(string fileType)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.FileName = string.Empty;
                openFileDialog.Filter = fileType;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file = File.ReadAllText(openFileDialog.FileName);
                    return 0;
                }
            }
            return -1;
        }

        //Переміщення форми (початок)
        private bool FormDragged = false;                                            // Мишка натиснута на border panel
        private Point StartMousePosition;                                      // Стартова позиція натискання мишки
        private void border_panel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDragged = true;                                                    // Мишка натиснута
            StartMousePosition = e.Location;                                   // Зміна стартової позиції
        }

        private void border_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormDragged)                                                       // Якщо мишка натиснута
            {                                                                   //
                Point screenPoint = PointToScreen(e.Location);                  // Перетворюємо локальні координати форми у глобальні екранні координати
                Location = new Point                                            // 
                    (screenPoint.X - StartMousePosition.X,                       // Змінюємо Location форми
                    screenPoint.Y - StartMousePosition.Y);                       //
            }
        }

        private void border_panel_MouseUp(object sender, MouseEventArgs e) => FormDragged = false;  // Змінюємо стан поля _dragged

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
        private Form ActiveForm;
        private void ChangeForm(Form form)
        {
            if (ActiveForm != null) ActiveForm.Close();
            ActiveForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            main_panel.Controls.Add(form);
            main_panel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void minimize_button_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized; // Згорнути програму

        private void close_button_Click(object sender, EventArgs e) => Application.Exit(); // Вихід з програми

        private Info MboxInfo;
        private void info_Click(object sender, EventArgs e)
        {
            if(MboxInfo == null || MboxInfo.IsDisposed) MboxInfo = new Info();
            MboxInfo.BringToFront();
            MboxInfo.Show();
        }
    }
}
