namespace project_nana
{
    partial class TextForm
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
            panel2 = new Panel();
            foundedText = new Label();
            nextText = new Button();
            previousText = new Button();
            search_txt_btn = new Button();
            search_txt = new TextBox();
            text_listbox = new ListBox();
            label1 = new Label();
            panel4 = new Panel();
            foundedWords = new Label();
            nextWord = new Button();
            search_wrods_btn = new Button();
            previousWord = new Button();
            search_word = new TextBox();
            frequencyWordsDataGridView = new DataGridView();
            word = new DataGridViewTextBoxColumn();
            frequency = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frequencyWordsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 52, 52);
            panel1.Controls.Add(generalStat);
            panel1.Location = new Point(20, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 150);
            panel1.TabIndex = 5;
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
            generalStat.Size = new Size(202, 150);
            generalStat.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 52, 52);
            panel2.Controls.Add(foundedText);
            panel2.Controls.Add(nextText);
            panel2.Controls.Add(previousText);
            panel2.Controls.Add(search_txt_btn);
            panel2.Controls.Add(search_txt);
            panel2.Controls.Add(text_listbox);
            panel2.Location = new Point(242, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 485);
            panel2.TabIndex = 7;
            // 
            // foundedText
            // 
            foundedText.AutoSize = true;
            foundedText.ForeColor = SystemColors.ButtonFace;
            foundedText.Location = new Point(351, 442);
            foundedText.Name = "foundedText";
            foundedText.Size = new Size(0, 15);
            foundedText.TabIndex = 8;
            // 
            // nextText
            // 
            nextText.BackColor = Color.FromArgb(31, 31, 31);
            nextText.BackgroundImageLayout = ImageLayout.Zoom;
            nextText.FlatAppearance.BorderSize = 0;
            nextText.FlatStyle = FlatStyle.Flat;
            nextText.Font = new Font("Segoe UI Semilight", 9F);
            nextText.ForeColor = SystemColors.ButtonFace;
            nextText.Image = Properties.Resources.Arrow_drop_down_big;
            nextText.Location = new Point(320, 437);
            nextText.Name = "nextText";
            nextText.Padding = new Padding(0, 0, 0, 3);
            nextText.Size = new Size(25, 25);
            nextText.TabIndex = 7;
            nextText.UseVisualStyleBackColor = false;
            // 
            // previousText
            // 
            previousText.BackColor = Color.FromArgb(31, 31, 31);
            previousText.BackgroundImageLayout = ImageLayout.Zoom;
            previousText.FlatAppearance.BorderSize = 0;
            previousText.FlatStyle = FlatStyle.Flat;
            previousText.Font = new Font("Segoe UI Semilight", 9F);
            previousText.ForeColor = SystemColors.ButtonFace;
            previousText.Image = Properties.Resources.Arrow_drop_up_big;
            previousText.Location = new Point(289, 437);
            previousText.Name = "previousText";
            previousText.Padding = new Padding(0, 0, 0, 3);
            previousText.Size = new Size(25, 25);
            previousText.TabIndex = 6;
            previousText.UseVisualStyleBackColor = false;
            // 
            // search_txt_btn
            // 
            search_txt_btn.BackColor = Color.FromArgb(31, 31, 31);
            search_txt_btn.BackgroundImageLayout = ImageLayout.Zoom;
            search_txt_btn.FlatAppearance.BorderSize = 0;
            search_txt_btn.FlatStyle = FlatStyle.Flat;
            search_txt_btn.Font = new Font("Segoe UI Semilight", 9F);
            search_txt_btn.ForeColor = SystemColors.ButtonFace;
            search_txt_btn.Image = Properties.Resources.Search_alt_light;
            search_txt_btn.Location = new Point(258, 437);
            search_txt_btn.Name = "search_txt_btn";
            search_txt_btn.Padding = new Padding(0, 0, 0, 3);
            search_txt_btn.Size = new Size(25, 25);
            search_txt_btn.TabIndex = 5;
            search_txt_btn.UseVisualStyleBackColor = false;
            // 
            // search_txt
            // 
            search_txt.BackColor = Color.FromArgb(31, 31, 31);
            search_txt.BorderStyle = BorderStyle.FixedSingle;
            search_txt.Font = new Font("Segoe UI", 10F);
            search_txt.ForeColor = SystemColors.ButtonFace;
            search_txt.Location = new Point(3, 437);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(250, 25);
            search_txt.TabIndex = 1;
            search_txt.KeyDown += search_txt_KeyDown;
            // 
            // text_listbox
            // 
            text_listbox.BackColor = Color.FromArgb(52, 52, 52);
            text_listbox.BorderStyle = BorderStyle.None;
            text_listbox.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            text_listbox.ForeColor = SystemColors.ButtonFace;
            text_listbox.FormattingEnabled = true;
            text_listbox.ItemHeight = 17;
            text_listbox.Location = new Point(0, 0);
            text_listbox.Name = "text_listbox";
            text_listbox.Size = new Size(632, 425);
            text_listbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 22F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 6;
            label1.Text = "Статистика";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 52, 52);
            panel4.Controls.Add(foundedWords);
            panel4.Controls.Add(nextWord);
            panel4.Controls.Add(search_wrods_btn);
            panel4.Controls.Add(previousWord);
            panel4.Controls.Add(search_word);
            panel4.Controls.Add(frequencyWordsDataGridView);
            panel4.Location = new Point(20, 245);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 315);
            panel4.TabIndex = 8;
            // 
            // foundedWords
            // 
            foundedWords.AutoSize = true;
            foundedWords.ForeColor = SystemColors.ButtonFace;
            foundedWords.Location = new Point(3, 296);
            foundedWords.Name = "foundedWords";
            foundedWords.Size = new Size(0, 15);
            foundedWords.TabIndex = 9;
            // 
            // nextWord
            // 
            nextWord.BackColor = Color.FromArgb(31, 31, 31);
            nextWord.BackgroundImageLayout = ImageLayout.Zoom;
            nextWord.FlatAppearance.BorderSize = 0;
            nextWord.FlatStyle = FlatStyle.Flat;
            nextWord.Font = new Font("Segoe UI Semilight", 9F);
            nextWord.ForeColor = SystemColors.ButtonFace;
            nextWord.Image = Properties.Resources.Arrow_drop_down_big;
            nextWord.Location = new Point(174, 268);
            nextWord.Name = "nextWord";
            nextWord.Padding = new Padding(0, 0, 0, 3);
            nextWord.Size = new Size(25, 25);
            nextWord.TabIndex = 10;
            nextWord.UseVisualStyleBackColor = false;
            // 
            // search_wrods_btn
            // 
            search_wrods_btn.BackColor = Color.FromArgb(31, 31, 31);
            search_wrods_btn.BackgroundImageLayout = ImageLayout.Zoom;
            search_wrods_btn.FlatAppearance.BorderSize = 0;
            search_wrods_btn.FlatStyle = FlatStyle.Flat;
            search_wrods_btn.Font = new Font("Segoe UI Semilight", 9F);
            search_wrods_btn.ForeColor = SystemColors.ButtonFace;
            search_wrods_btn.Image = Properties.Resources.Search_alt_light;
            search_wrods_btn.Location = new Point(112, 268);
            search_wrods_btn.Name = "search_wrods_btn";
            search_wrods_btn.Padding = new Padding(0, 0, 0, 3);
            search_wrods_btn.Size = new Size(25, 25);
            search_wrods_btn.TabIndex = 4;
            search_wrods_btn.UseVisualStyleBackColor = false;
            // 
            // previousWord
            // 
            previousWord.BackColor = Color.FromArgb(31, 31, 31);
            previousWord.BackgroundImageLayout = ImageLayout.Zoom;
            previousWord.FlatAppearance.BorderSize = 0;
            previousWord.FlatStyle = FlatStyle.Flat;
            previousWord.Font = new Font("Segoe UI Semilight", 9F);
            previousWord.ForeColor = SystemColors.ButtonFace;
            previousWord.Image = Properties.Resources.Arrow_drop_up_big;
            previousWord.Location = new Point(143, 268);
            previousWord.Name = "previousWord";
            previousWord.Padding = new Padding(0, 0, 0, 3);
            previousWord.Size = new Size(25, 25);
            previousWord.TabIndex = 9;
            previousWord.UseVisualStyleBackColor = false;
            // 
            // search_word
            // 
            search_word.BackColor = Color.FromArgb(31, 31, 31);
            search_word.BorderStyle = BorderStyle.FixedSingle;
            search_word.Font = new Font("Segoe UI", 10F);
            search_word.ForeColor = SystemColors.ButtonFace;
            search_word.Location = new Point(3, 268);
            search_word.Name = "search_word";
            search_word.Size = new Size(103, 25);
            search_word.TabIndex = 3;
            search_word.KeyDown += search_word_KeyDown;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
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
            frequencyWordsDataGridView.GridColor = Color.FromArgb(31, 31, 31);
            frequencyWordsDataGridView.Location = new Point(0, 1);
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
            frequencyWordsDataGridView.RowHeadersWidth = 60;
            frequencyWordsDataGridView.ScrollBars = ScrollBars.Vertical;
            frequencyWordsDataGridView.Size = new Size(224, 255);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(20, 227);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 13;
            label5.Text = "Частота вживання слів";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(242, 57);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 11;
            label3.Text = "Текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(20, 57);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 12;
            label2.Text = "Загальна статистика";
            // 
            // TextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(885, 574);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(885, 574);
            MinimumSize = new Size(885, 574);
            Name = "TextForm";
            Text = "TextForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frequencyWordsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListBox generalStat;
        private Panel panel2;
        private TextBox search_txt;
        private ListBox text_listbox;
        private Label label1;
        private Panel panel4;
        private DataGridView frequencyWordsDataGridView;
        private DataGridViewTextBoxColumn word;
        private DataGridViewTextBoxColumn frequency;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button search_wrods_btn;
        private TextBox search_word;
        private Button search_txt_btn;
        private Button nextText;
        private Button previousText;
        private Label foundedText;
        private Button nextWord;
        private Button previousWord;
        private Label foundedWords;
    }
}