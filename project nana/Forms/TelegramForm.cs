using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_nana
{
    public partial class TelegramForm : Form
    {
        ChatAnalyzer ChatAnalyzer = new ChatAnalyzer();
        ChatAnalyzerResult ResultAnalyze;
        DataChat chat;
        public TelegramForm()
        {
            InitializeComponent();
        }

        public void TakeStat(string json)
        {
            chat = DataChatSet.CreateNewDataChat(json);
            ResultAnalyze = ChatAnalyzer.Analyze(chat);
            TakeAllTgStat();

        }

        private async Task TakeAllTgStat()
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
                    $"Перше повідомлення від користувача: ",
                    $"{ResultAnalyze.FirstChatMessage.From}",
                    $"Повідомлення: ",
                    $"{ResultAnalyze.FirstChatMessage.Date}",
                    $"{ResultAnalyze.FirstChatMessage.Text}"
                    });
                }));
                //foreach (Message message in chat.Messages)
                //{
                //    if (message.Text == "") continue;
                //    allChatMessages.Invoke(new Action(() =>
                //    {
                //        allChatMessages.Items.Add($"{message.Date}, {message.From}: {message.Text}");
                //    }));
                //}
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
                            $"Мін. букв в слові: none" ,
                            $"Макс. букв в слові: none"
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
                    foreach (KeyValuePair<string, int> pair in ResultAnalyze.TextAnalyzerResult.FrequencyWords)
                    {
                        frequencyGridView.Rows.Add(pair.Key, pair.Value);
                    }
                    frequencyGridView.Sort(frequencyGridView.Columns[1], ListSortDirection.Descending);
                }));
            });
        }
    }
}
