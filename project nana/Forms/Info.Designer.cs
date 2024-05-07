namespace project_nana
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            border_panel = new Panel();
            form_icon = new PictureBox();
            form_name_label = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            image = new PictureBox();
            text = new Label();
            OK_btn = new Button();
            border_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)form_icon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // border_panel
            // 
            border_panel.BackColor = Color.FromArgb(26, 26, 26);
            border_panel.Controls.Add(form_icon);
            border_panel.Controls.Add(form_name_label);
            border_panel.Dock = DockStyle.Top;
            border_panel.Location = new Point(0, 0);
            border_panel.Name = "border_panel";
            border_panel.Size = new Size(400, 40);
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
            form_icon.TabIndex = 9;
            form_icon.TabStop = false;
            // 
            // form_name_label
            // 
            form_name_label.AutoSize = true;
            form_name_label.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            form_name_label.ForeColor = SystemColors.ButtonFace;
            form_name_label.Location = new Point(46, 9);
            form_name_label.Name = "form_name_label";
            form_name_label.Size = new Size(42, 20);
            form_name_label.TabIndex = 8;
            form_name_label.Text = "INFO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 46, 46);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(OK_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 160);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(image);
            panel2.Controls.Add(text);
            panel2.Location = new Point(12, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 100);
            panel2.TabIndex = 12;
            // 
            // image
            // 
            image.Dock = DockStyle.Left;
            image.Image = Properties.Resources.info_light_3x;
            image.Location = new Point(0, 0);
            image.Name = "image";
            image.Size = new Size(100, 100);
            image.SizeMode = PictureBoxSizeMode.CenterImage;
            image.TabIndex = 10;
            image.TabStop = false;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            text.ForeColor = SystemColors.ButtonFace;
            text.Location = new Point(106, 20);
            text.Name = "text";
            text.Size = new Size(249, 60);
            text.TabIndex = 10;
            text.Text = "Це программа аналізатор тексту та\r\nчатів в Telegram!\r\nСтудента Карпети Кирила 212/2";
            // 
            // OK_btn
            // 
            OK_btn.BackColor = Color.FromArgb(31, 31, 31);
            OK_btn.FlatAppearance.BorderSize = 0;
            OK_btn.FlatStyle = FlatStyle.Flat;
            OK_btn.Font = new Font("Segoe UI Semilight", 11.25F);
            OK_btn.ForeColor = SystemColors.ButtonFace;
            OK_btn.Image = Properties.Resources.OK;
            OK_btn.ImageAlign = ContentAlignment.BottomLeft;
            OK_btn.Location = new Point(228, 112);
            OK_btn.Name = "OK_btn";
            OK_btn.Padding = new Padding(10, 0, 0, 3);
            OK_btn.Size = new Size(160, 40);
            OK_btn.TabIndex = 11;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = false;
            OK_btn.Click += OK_btn_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(panel1);
            Controls.Add(border_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info";
            border_panel.ResumeLayout(false);
            border_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)form_icon).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel border_panel;
        private Panel panel1;
        private PictureBox form_icon;
        private Label form_name_label;
        private PictureBox image;
        private Label text;
        private Button OK_btn;
        private Panel panel2;
    }
}