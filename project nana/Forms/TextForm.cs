using System.ComponentModel;

namespace project_nana
{
    public partial class TextForm : Form
    {
        private TextAnalyzer TextAnalyzer = new TextAnalyzer();
        public TextAnalyzerResult ResultAnalyze;
        private List<int> TextSearchResult = new List<int>();
        private List<int> WordsSearhResult = new List<int>();
        public TextForm()
        {
            int currentTextIndex = 0;
            int currentWordIndex = 0;
            InitializeComponent();

            search_txt_btn.Click += (a, e) =>
            {
                TextSearchResult = SearchInListBox(text_listbox);
                foundedText.Text = $"Знайдено {TextSearchResult.Count} збігів";
            };
            nextText.Click += (a, e) =>
            {
                if (TextSearchResult.Count > 0)
                {
                    if (currentTextIndex + 1 >= TextSearchResult.Count) currentTextIndex = -1;
                    text_listbox.SelectedIndex = TextSearchResult[++currentTextIndex];
                }
            };
            previousText.Click += (a, e) =>
            {
                if (TextSearchResult.Count > 0)
                {
                    if (currentTextIndex - 1 < 0) currentTextIndex = TextSearchResult.Count;
                    text_listbox.SelectedIndex = TextSearchResult[--currentTextIndex];
                }
            };
            search_wrods_btn.Click += (a, e) =>
            {
                WordsSearhResult = SearchInDataGrid(frequencyWordsDataGridView);
                foundedWords.Text = $"Знайдено {WordsSearhResult.Count} збігів";
            };
            nextWord.Click += (a, e) =>
            {
                if (WordsSearhResult.Count > 0)
                {
                    if (currentWordIndex + 1 >= WordsSearhResult.Count) currentWordIndex = -1;
                    frequencyWordsDataGridView.ClearSelection();
                    frequencyWordsDataGridView.Rows[WordsSearhResult[++currentWordIndex]].Selected = true;
                    frequencyWordsDataGridView.FirstDisplayedScrollingRowIndex = WordsSearhResult[currentWordIndex];
                }
            };
            previousWord.Click += (a, e) =>
            {
                if (WordsSearhResult.Count > 0)
                {
                    if (currentWordIndex - 1 < 0) currentWordIndex = WordsSearhResult.Count;
                    frequencyWordsDataGridView.ClearSelection();
                    frequencyWordsDataGridView.Rows[WordsSearhResult[--currentWordIndex]].Selected = true;
                    frequencyWordsDataGridView.FirstDisplayedScrollingRowIndex = WordsSearhResult[currentWordIndex];
                }
            };
        }
        public async void TakeStat(List<string> text)
        {
            ResultAnalyze = TextAnalyzer.Analyze(text);
            await TakeAllTextStat();
        }
        public async Task TakeAllTextStat()
        {
            Task takeFrequencyWords = TakeFrequencyWordsAsync(frequencyWordsDataGridView);
            Task takeGeneralStat = TakeGeneralStatAsync(generalStat);
            Task outPutText = OutPutTextAsync(text_listbox);
            await Task.WhenAll(takeFrequencyWords, takeGeneralStat, outPutText);
        }
        private async Task TakeFrequencyWordsAsync(DataGridView frequencyGridView)
        {
            await Task.Run(() =>
            {
                frequencyGridView.Invoke(new Action(() =>
                {
                    foreach (KeyValuePair<string, int> pair in ResultAnalyze.FrequencyWords)
                    {
                        frequencyGridView.Rows.Add(pair.Key, pair.Value);
                    }
                    frequencyGridView.Sort(frequencyGridView.Columns[1], ListSortDirection.Descending);
                }));
            });
        }
        private async Task TakeGeneralStatAsync(ListBox generalStat)
        {
            await Task.Run(() =>
            {
                generalStat.Invoke(new Action(() =>
                {
                    generalStat.Items.AddRange(new string[]
                        {
                            $"Слів: {ResultAnalyze.WordsCount}",
                            $"Пунктуації: {ResultAnalyze.CountSpecialSymbols}" ,
                            $"Середня довжина слова: {Math.Round(ResultAnalyze.WordsLengthAVG,2)}" ,
                            $"Мін. букв в слові: {ResultAnalyze.WordsMinLength}" ,
                            $"Макс. букв в слові: {ResultAnalyze.WordsMaxLength}"
                        });
                }));
            });
        }
        private async Task OutPutTextAsync(ListBox textListBox)
        {
            await Task.Run(() =>
            {
                textListBox.Invoke(new Action(() =>
                {
                    textListBox.Items.AddRange(ResultAnalyze.Text.ToArray());
                }));
            });
        }
        private List<int> SearchInListBox(ListBox textListBox)
        {
            List<int> searchResults = new List<int>();
            if (search_txt.Text != string.Empty && text_listbox.Items.Count > 0)
            {
                for (int i = 0; i < text_listbox.Items.Count; i++)
                {
                    string tempLine = text_listbox.Items[i].ToString().ToLower();
                    if (tempLine.Contains(search_txt.Text.ToLower())) searchResults.Add(i);
                }
                if (searchResults.Count > 0)
                {
                    textListBox.SelectedIndex = searchResults[0];
                    textListBox.TopIndex = searchResults[0];
                }
            }
            return searchResults;
        }
        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) search_txt_btn.PerformClick();
        }
        private void search_word_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) search_wrods_btn.PerformClick();
        }
        private List<int> SearchInDataGrid(DataGridView table)
        {
            List<int> searchResults = new List<int>();
            if (search_word.Text != string.Empty && table.Rows.Count > 0)
            {
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    string tempWord = table[0, row].Value.ToString();
                    if (tempWord.Contains(search_word.Text.ToLower())) searchResults.Add(row);
                }
                if (searchResults.Count > 0)
                {
                    frequencyWordsDataGridView.Rows[searchResults[0]].Selected = true;
                    frequencyWordsDataGridView.FirstDisplayedScrollingRowIndex = searchResults[0];
                }
            }
            return searchResults;
        }
    }
}
