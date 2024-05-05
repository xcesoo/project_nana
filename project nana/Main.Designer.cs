namespace project_nana
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            border_panel = new Panel();
            form_icon = new PictureBox();
            form_name_label = new Label();
            minimize_button = new Button();
            close_button = new Button();
            main_panel = new Panel();
            sub_menu_export = new Panel();
            export_json = new Button();
            side_menu_panel = new Panel();
            info = new Button();
            version = new Label();
            export_btn = new Button();
            sub_menu_import = new Panel();
            import_stat_json = new Button();
            import_telegram_json = new Button();
            import_txt = new Button();
            import_btn = new Button();
            border_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)form_icon).BeginInit();
            sub_menu_export.SuspendLayout();
            side_menu_panel.SuspendLayout();
            sub_menu_import.SuspendLayout();
            SuspendLayout();
            // 
            // border_panel
            // 
            border_panel.BackColor = Color.FromArgb(26, 26, 26);
            border_panel.Controls.Add(form_icon);
            border_panel.Controls.Add(form_name_label);
            border_panel.Controls.Add(minimize_button);
            border_panel.Controls.Add(close_button);
            border_panel.Dock = DockStyle.Top;
            border_panel.Location = new Point(0, 0);
            border_panel.Name = "border_panel";
            border_panel.Size = new Size(900, 40);
            border_panel.TabIndex = 0;
            border_panel.MouseDown += border_panel_MouseDown;
            border_panel.MouseMove += border_panel_MouseMove;
            border_panel.MouseUp += border_panel_MouseUp;
            // 
            // form_icon
            // 
            form_icon.Image = Properties.Resources.icon;
            form_icon.Location = new Point(0, 0);
            form_icon.Name = "form_icon";
            form_icon.Size = new Size(40, 40);
            form_icon.SizeMode = PictureBoxSizeMode.CenterImage;
            form_icon.TabIndex = 7;
            form_icon.TabStop = false;
            form_icon.Click += form_icon_Click;
            // 
            // form_name_label
            // 
            form_name_label.AutoSize = true;
            form_name_label.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            form_name_label.ForeColor = SystemColors.ButtonFace;
            form_name_label.Location = new Point(46, 9);
            form_name_label.Name = "form_name_label";
            form_name_label.Size = new Size(91, 20);
            form_name_label.TabIndex = 6;
            form_name_label.Text = "project nana";
            // 
            // minimize_button
            // 
            minimize_button.FlatAppearance.BorderSize = 0;
            minimize_button.FlatStyle = FlatStyle.Flat;
            minimize_button.Image = Properties.Resources.minimize_ring_fill;
            minimize_button.Location = new Point(814, 0);
            minimize_button.Name = "minimize_button";
            minimize_button.Size = new Size(40, 40);
            minimize_button.TabIndex = 5;
            minimize_button.UseVisualStyleBackColor = true;
            minimize_button.Click += minimize_button_Click;
            // 
            // close_button
            // 
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.Image = Properties.Resources.close_ring_fill;
            close_button.Location = new Point(860, 0);
            close_button.Name = "close_button";
            close_button.Size = new Size(40, 40);
            close_button.TabIndex = 4;
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.FromArgb(31, 31, 31);
            main_panel.Dock = DockStyle.Right;
            main_panel.Location = new Point(150, 40);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(750, 485);
            main_panel.TabIndex = 1;
            // 
            // sub_menu_export
            // 
            sub_menu_export.BackColor = Color.FromArgb(52, 52, 52);
            sub_menu_export.Controls.Add(export_json);
            sub_menu_export.Dock = DockStyle.Top;
            sub_menu_export.Location = new Point(0, 200);
            sub_menu_export.Name = "sub_menu_export";
            sub_menu_export.Size = new Size(150, 40);
            sub_menu_export.TabIndex = 3;
            sub_menu_export.Visible = false;
            // 
            // export_json
            // 
            export_json.Dock = DockStyle.Top;
            export_json.FlatAppearance.BorderSize = 0;
            export_json.FlatStyle = FlatStyle.Flat;
            export_json.Font = new Font("Segoe UI Semilight", 10F);
            export_json.ForeColor = SystemColors.ButtonFace;
            export_json.ImageAlign = ContentAlignment.BottomLeft;
            export_json.Location = new Point(0, 0);
            export_json.Name = "export_json";
            export_json.Padding = new Padding(0, 0, 0, 3);
            export_json.Size = new Size(150, 40);
            export_json.TabIndex = 2;
            export_json.Text = "Json file (.json)";
            export_json.UseVisualStyleBackColor = true;
            // 
            // side_menu_panel
            // 
            side_menu_panel.BackColor = Color.FromArgb(46, 46, 46);
            side_menu_panel.Controls.Add(info);
            side_menu_panel.Controls.Add(version);
            side_menu_panel.Controls.Add(sub_menu_export);
            side_menu_panel.Controls.Add(export_btn);
            side_menu_panel.Controls.Add(sub_menu_import);
            side_menu_panel.Controls.Add(import_btn);
            side_menu_panel.Dock = DockStyle.Left;
            side_menu_panel.Location = new Point(0, 40);
            side_menu_panel.Name = "side_menu_panel";
            side_menu_panel.Size = new Size(150, 485);
            side_menu_panel.TabIndex = 2;
            // 
            // info
            // 
            info.FlatAppearance.BorderSize = 0;
            info.FlatStyle = FlatStyle.Flat;
            info.Font = new Font("Segoe UI Semilight", 11.25F);
            info.ForeColor = SystemColors.ButtonFace;
            info.Image = Properties.Resources.info_light;
            info.ImageAlign = ContentAlignment.BottomLeft;
            info.Location = new Point(0, 417);
            info.Name = "info";
            info.Padding = new Padding(10, 0, 0, 3);
            info.Size = new Size(150, 40);
            info.TabIndex = 5;
            info.Text = "Info";
            info.UseVisualStyleBackColor = true;
            info.Click += info_Click;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Dock = DockStyle.Bottom;
            version.ForeColor = SystemColors.ButtonFace;
            version.Location = new Point(0, 460);
            version.Name = "version";
            version.Padding = new Padding(10, 0, 0, 10);
            version.Size = new Size(99, 25);
            version.TabIndex = 4;
            version.Text = "version: 0.1beta";
            // 
            // export_btn
            // 
            export_btn.Dock = DockStyle.Top;
            export_btn.FlatAppearance.BorderSize = 0;
            export_btn.FlatStyle = FlatStyle.Flat;
            export_btn.Font = new Font("Segoe UI Semilight", 11.25F);
            export_btn.ForeColor = SystemColors.ButtonFace;
            export_btn.Image = Properties.Resources.export;
            export_btn.ImageAlign = ContentAlignment.BottomLeft;
            export_btn.Location = new Point(0, 160);
            export_btn.Name = "export_btn";
            export_btn.Padding = new Padding(10, 0, 0, 3);
            export_btn.Size = new Size(150, 40);
            export_btn.TabIndex = 1;
            export_btn.Text = "Export";
            export_btn.UseVisualStyleBackColor = true;
            export_btn.Click += export_btn_Click;
            // 
            // sub_menu_import
            // 
            sub_menu_import.BackColor = Color.FromArgb(52, 52, 52);
            sub_menu_import.Controls.Add(import_stat_json);
            sub_menu_import.Controls.Add(import_telegram_json);
            sub_menu_import.Controls.Add(import_txt);
            sub_menu_import.Dock = DockStyle.Top;
            sub_menu_import.Location = new Point(0, 40);
            sub_menu_import.Name = "sub_menu_import";
            sub_menu_import.Size = new Size(150, 120);
            sub_menu_import.TabIndex = 0;
            sub_menu_import.Visible = false;
            // 
            // import_stat_json
            // 
            import_stat_json.Dock = DockStyle.Top;
            import_stat_json.FlatAppearance.BorderSize = 0;
            import_stat_json.FlatStyle = FlatStyle.Flat;
            import_stat_json.Font = new Font("Segoe UI Semilight", 10F);
            import_stat_json.ForeColor = SystemColors.ButtonFace;
            import_stat_json.ImageAlign = ContentAlignment.BottomLeft;
            import_stat_json.Location = new Point(0, 80);
            import_stat_json.Name = "import_stat_json";
            import_stat_json.Padding = new Padding(0, 0, 0, 3);
            import_stat_json.Size = new Size(150, 40);
            import_stat_json.TabIndex = 3;
            import_stat_json.Text = "Statistics file (.json)";
            import_stat_json.UseVisualStyleBackColor = true;
            // 
            // import_telegram_json
            // 
            import_telegram_json.Dock = DockStyle.Top;
            import_telegram_json.FlatAppearance.BorderSize = 0;
            import_telegram_json.FlatStyle = FlatStyle.Flat;
            import_telegram_json.Font = new Font("Segoe UI Semilight", 10F);
            import_telegram_json.ForeColor = SystemColors.ButtonFace;
            import_telegram_json.ImageAlign = ContentAlignment.BottomLeft;
            import_telegram_json.Location = new Point(0, 40);
            import_telegram_json.Name = "import_telegram_json";
            import_telegram_json.Padding = new Padding(0, 0, 0, 3);
            import_telegram_json.Size = new Size(150, 40);
            import_telegram_json.TabIndex = 2;
            import_telegram_json.Text = "Telegram chat (.json)";
            import_telegram_json.UseVisualStyleBackColor = true;
            // 
            // import_txt
            // 
            import_txt.Dock = DockStyle.Top;
            import_txt.FlatAppearance.BorderSize = 0;
            import_txt.FlatStyle = FlatStyle.Flat;
            import_txt.Font = new Font("Segoe UI Semilight", 10F);
            import_txt.ForeColor = SystemColors.ButtonFace;
            import_txt.ImageAlign = ContentAlignment.BottomLeft;
            import_txt.Location = new Point(0, 0);
            import_txt.Name = "import_txt";
            import_txt.Padding = new Padding(0, 0, 0, 3);
            import_txt.Size = new Size(150, 40);
            import_txt.TabIndex = 1;
            import_txt.Text = "Text file (.txt)";
            import_txt.UseVisualStyleBackColor = true;
            // 
            // import_btn
            // 
            import_btn.Dock = DockStyle.Top;
            import_btn.FlatAppearance.BorderSize = 0;
            import_btn.FlatStyle = FlatStyle.Flat;
            import_btn.Font = new Font("Segoe UI Semilight", 11.25F);
            import_btn.ForeColor = SystemColors.ButtonFace;
            import_btn.Image = Properties.Resources.import;
            import_btn.ImageAlign = ContentAlignment.BottomLeft;
            import_btn.Location = new Point(0, 0);
            import_btn.Name = "import_btn";
            import_btn.Padding = new Padding(10, 0, 0, 3);
            import_btn.Size = new Size(150, 40);
            import_btn.TabIndex = 0;
            import_btn.Text = "Import";
            import_btn.UseVisualStyleBackColor = true;
            import_btn.Click += import_btn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(900, 525);
            Controls.Add(side_menu_panel);
            Controls.Add(main_panel);
            Controls.Add(border_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            border_panel.ResumeLayout(false);
            border_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)form_icon).EndInit();
            sub_menu_export.ResumeLayout(false);
            side_menu_panel.ResumeLayout(false);
            side_menu_panel.PerformLayout();
            sub_menu_import.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel border_panel;
        private Button minimize_button;
        private Button close_button;
        private Panel main_panel;
        private Label form_name_label;
        private PictureBox form_icon;
        private Button import_btn;
        private Panel side_menu_panel;
        private Panel sub_menu_import;
        private Button import_telegram_json;
        private Button import_txt;
        private Panel sub_menu_export;
        private Button export_json;
        private Button export_btn;
        private Button import_stat_json;
        private Label version;
        private Button info;
    }
}
