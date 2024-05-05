namespace project_nana
{
    partial class TelegramForm
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            telegram_stat_textbox = new TextBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 52, 52);
            panel1.Location = new Point(20, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 150);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(200, 50);
            label1.TabIndex = 0;
            label1.Text = "Статистика";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 52, 52);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(270, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 390);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 52, 52);
            panel3.Controls.Add(telegram_stat_textbox);
            panel3.Location = new Point(510, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 390);
            panel3.TabIndex = 2;
            // 
            // telegram_stat_textbox
            // 
            telegram_stat_textbox.BackColor = Color.FromArgb(52, 52, 52);
            telegram_stat_textbox.BorderStyle = BorderStyle.None;
            telegram_stat_textbox.ForeColor = SystemColors.ButtonFace;
            telegram_stat_textbox.Location = new Point(3, 3);
            telegram_stat_textbox.Multiline = true;
            telegram_stat_textbox.Name = "telegram_stat_textbox";
            telegram_stat_textbox.Size = new Size(214, 384);
            telegram_stat_textbox.TabIndex = 0;
            telegram_stat_textbox.MouseWheel += telegram_stat_textbox_MouseWheel;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 52, 52);
            panel4.Location = new Point(20, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 220);
            panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(52, 52, 52);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 384);
            textBox1.TabIndex = 1;
            // 
            // TelegramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(750, 485);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(750, 485);
            MinimumSize = new Size(750, 485);
            Name = "TelegramForm";
            Text = "TelegramForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox telegram_stat_textbox;
        private TextBox textBox1;
    }
}