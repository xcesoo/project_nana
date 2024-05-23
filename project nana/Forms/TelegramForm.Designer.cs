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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            generalStat = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            stat = new ListBox();
            panel3 = new Panel();
            usersStat = new ListBox();
            panel4 = new Panel();
            frequencyWordsDataGridView = new DataGridView();
            word = new DataGridViewTextBoxColumn();
            frequency = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frequencyWordsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 52, 52);
            panel1.Controls.Add(generalStat);
            panel1.Location = new Point(20, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 150);
            panel1.TabIndex = 0;
            // 
            // generalStat
            // 
            generalStat.BackColor = Color.FromArgb(52, 52, 52);
            generalStat.BorderStyle = BorderStyle.None;
            generalStat.Dock = DockStyle.Fill;
            generalStat.Font = new Font("Segoe UI", 10F);
            generalStat.ForeColor = SystemColors.ButtonFace;
            generalStat.FormattingEnabled = true;
            generalStat.ItemHeight = 17;
            generalStat.Location = new Point(0, 0);
            generalStat.Name = "generalStat";
            generalStat.Size = new Size(185, 150);
            generalStat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 0;
            label1.Text = "Статистика";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 52, 52);
            panel2.Controls.Add(stat);
            panel2.Location = new Point(225, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 485);
            panel2.TabIndex = 1;
            // 
            // stat
            // 
            stat.BackColor = Color.FromArgb(52, 52, 52);
            stat.BorderStyle = BorderStyle.None;
            stat.Dock = DockStyle.Top;
            stat.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stat.ForeColor = SystemColors.ButtonFace;
            stat.FormattingEnabled = true;
            stat.ItemHeight = 17;
            stat.Location = new Point(0, 0);
            stat.Name = "stat";
            stat.Size = new Size(310, 425);
            stat.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 52, 52);
            panel3.Controls.Add(usersStat);
            panel3.Location = new Point(555, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 485);
            panel3.TabIndex = 2;
            // 
            // usersStat
            // 
            usersStat.BackColor = Color.FromArgb(52, 52, 52);
            usersStat.BorderStyle = BorderStyle.None;
            usersStat.Dock = DockStyle.Top;
            usersStat.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usersStat.ForeColor = SystemColors.ButtonFace;
            usersStat.FormattingEnabled = true;
            usersStat.ItemHeight = 17;
            usersStat.Location = new Point(0, 0);
            usersStat.Name = "usersStat";
            usersStat.Size = new Size(310, 425);
            usersStat.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 52, 52);
            panel4.Controls.Add(frequencyWordsDataGridView);
            panel4.Location = new Point(20, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 315);
            panel4.TabIndex = 1;
            // 
            // frequencyWordsDataGridView
            // 
            frequencyWordsDataGridView.AllowUserToAddRows = false;
            frequencyWordsDataGridView.AllowUserToDeleteRows = false;
            frequencyWordsDataGridView.AllowUserToOrderColumns = true;
            frequencyWordsDataGridView.BackgroundColor = Color.FromArgb(52, 52, 52);
            frequencyWordsDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 74, 74);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            frequencyWordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            frequencyWordsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            frequencyWordsDataGridView.ColumnHeadersVisible = false;
            frequencyWordsDataGridView.Columns.AddRange(new DataGridViewColumn[] { word, frequency });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 74, 74);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            frequencyWordsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            frequencyWordsDataGridView.Dock = DockStyle.Top;
            frequencyWordsDataGridView.GridColor = Color.FromArgb(31, 31, 31);
            frequencyWordsDataGridView.Location = new Point(0, 0);
            frequencyWordsDataGridView.Name = "frequencyWordsDataGridView";
            frequencyWordsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(52, 52, 52);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(74, 74, 74);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            frequencyWordsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            frequencyWordsDataGridView.RowHeadersVisible = false;
            frequencyWordsDataGridView.ScrollBars = ScrollBars.Vertical;
            frequencyWordsDataGridView.Size = new Size(185, 280);
            frequencyWordsDataGridView.TabIndex = 0;
            // 
            // word
            // 
            word.HeaderText = "Слово";
            word.Name = "word";
            word.ReadOnly = true;
            // 
            // frequency
            // 
            frequency.HeaderText = "Частота";
            frequency.Name = "frequency";
            frequency.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "Загальна статистика";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(225, 52);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 3;
            label3.Text = "Чат";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(555, 52);
            label4.Name = "label4";
            label4.Size = new Size(162, 15);
            label4.TabIndex = 3;
            label4.Text = "Статистика по користувачам";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(20, 222);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 4;
            label5.Text = "Частота вживання слів";
            // 
            // TelegramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(885, 574);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(885, 574);
            MinimumSize = new Size(885, 574);
            Name = "TelegramForm";
            Text = "TelegramForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)frequencyWordsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView frequencyWordsDataGridView;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox stat;
        private ListBox usersStat;
        private ListBox generalStat;
        private DataGridViewTextBoxColumn word;
        private DataGridViewTextBoxColumn frequency;
    }
}