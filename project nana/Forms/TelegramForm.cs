using System.ComponentModel;
using System.Data;

namespace project_nana
{
    public partial class TelegramForm : Form
    {
        public ChatAnalyzerResult ResultAnalyze;
        private ChatAnalyzer ChatAnalyzer = new ChatAnalyzer();
        private DataChat chat;
        private List<int> WordsSearhResult = new List<int>();
        public TelegramForm()
        {
            InitializeComponent();

            int currentWordIndex = 0;
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

        public async void TakeStat(string json)
        {
            try
            {
                chat = DataChatSet.CreateNewDataChat(json);
                ResultAnalyze = ChatAnalyzer.Analyze(chat);
                await TakeAllTgStat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка зчитування файлу","Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        public async Task TakeAllTgStat()
        {
            Task takeChatMessages = TakeAllChatMessagesAsync(stat);
            Task takeChatUsers = TakeUsersStatAsync(usersStat);
            Task takeGeneralStat = TakeGeneralStatAsync(generalStat);
            Task takeFrequencyWords = TakeFrequencyWordsAsync(frequencyWordsDataGridView);
            await Task.WhenAll(takeChatMessages, takeChatUsers, takeGeneralStat, takeFrequencyWords);
        }
        private async Task TakeAllChatMessagesAsync(ListBox stat)
        {
            await Task.Run(() =>
            {
                stat.Invoke(new Action(() =>
                {
                    stat.Items.AddRange(new string[]
                    {
                    $"Перше текстове повідомлення від користувача: ",
                    $"{ResultAnalyze.FirstChatMessage.From}",
                    $"Повідомлення: ",
                    $"{ResultAnalyze.FirstChatMessage.Date}",
                    $"{ResultAnalyze.FirstChatMessage.Text}",
                    $"",
                    $"Активність по годинам (%)",
                    });
                    for (int i = 0; i < ResultAnalyze.ActiveHours.Count; i++)
                    {
                        stat.Items.Add($"{i}:00 -> {Math.Round((double)ResultAnalyze.ActiveHours[i] / (double)chat.Messages.Count * 100, 2)}% -> {ResultAnalyze.ActiveHours[i]}");
                    }
                }));
            });
        }
        private async Task TakeUsersStatAsync(ListBox userStat)
        {
            usersStat.Items.AddRange(
                new string[]
                {
                    $"Назва чату: {chat.Name}",
                    $"Тип чату: {chat.Type}",
                    $"ID чату: {chat.Id}",
                    $"Кількість повідомлень: {chat.Messages.Count}",
                    $"Кількість користувачів: {ResultAnalyze.ChatUsers.Count}"
                });
            await Task.Run(() =>
            {
                foreach (User user in ResultAnalyze.ChatUsers)
                {
                    UserMessagesData data = ResultAnalyze.UserMessagesData[user.Id];
                    userStat.Invoke(new Action(() =>
                    {
                        userStat.Items.Add("");
                        usersStat.Items.AddRange
                        (
                            new string[]
                            {
                                $"ID користувача: {user.Id}",
                                $"\tІм'я: {data.Name}" ,
                                $"\tКількість повідомлень: {data.MessageCount}" ,
                                $"\tФото: {data.MessageCountPhoto}" ,
                                $"\tВідео: {data.MessageCountVideo}" ,
                                $"\tВідео-кружок: {data.MessageCountCircleVideo}" ,
                                $"\tАудіофайл: {data.MessageCountAudio}" ,
                                $"\tГолосове повідомлення: {data.MessageCountVoice}" ,
                                $"\tGIF: {data.MessageCountGIF}" ,
                                $"\tSticker: {data.MessageCountSticker}" ,
                                $"\tДзвінків: {data.CountPhoneCalls}"
                            }
                        );
                    }));
                }
            });
        }
        private async Task TakeGeneralStatAsync(ListBox generalStat)
        {
            await Task.Run(() =>
            {
                generalStat.Invoke(new Action(() =>
                {
                    generalStat.Items.AddRange
                    (
                        new string[]
                        {
                            $"Слів: {ResultAnalyze.TextAnalyzerResult.WordsCount}",
                            $"Пунктуації: {ResultAnalyze.TextAnalyzerResult.CountSpecialSymbols}" ,
                            $"Середня довжина слова: {ResultAnalyze.TextAnalyzerResult.WordsLengthAVG}" ,
                            $"Мін. букв в слові: {ResultAnalyze.TextAnalyzerResult.WordsMinLength}" ,
                            $"Макс. букв в слові: {ResultAnalyze.TextAnalyzerResult.WordsMaxLength}"
                        }
                    );
                }));
            });
        }
        private async Task TakeFrequencyWordsAsync(DataGridView frequencyGridView)
        {
            await Task.Run(() =>
            {
                frequencyGridView.Invoke(new Action(() =>
                {
                    Dictionary<string, int> frequency = ResultAnalyze.TextAnalyzerResult.FrequencyWords.Where(x => x.Value >= 50).ToDictionary(x => x.Key, y => y.Value);
                    foreach (KeyValuePair<string, int> pair in frequency)
                    {
                        frequencyGridView.Rows.Add(pair.Key, pair.Value);
                    }
                    frequencyGridView.Sort(frequencyGridView.Columns[1], ListSortDirection.Descending);
                }));
            });
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
