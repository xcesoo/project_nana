using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_nana
{
    class ChatAnalyzer
    {
        public ChatAnalyzerResult Analyze(DataChat chat)
        {
            TextAnalyzer textAnalyzer = new TextAnalyzer();
            List<string> text = chat.Messages.Select(x => (string)x.Text).ToList();
            List<User> users = AnalyzeUsers(chat);
            return new ChatAnalyzerResult
                (
                users, 
                textAnalyzer.Analyze(text), 
                TakeStatisticsALLUsers(users), 
                FindFirstUserMessage(chat.Messages),
                TakeActiveByHours(chat)
                );
        }
        private List<User> AnalyzeUsers(DataChat chat) 
        {
            List<User> chat_users = new List<User>();
            var userMessages = new Dictionary<string, List<Message>>();
            foreach (var message in chat.Messages)
            {
                if (message.ActorId ==null && message.FromId == null) continue;
                if (!userMessages.ContainsKey(message.FromId ?? message.ActorId)) userMessages[message.FromId ?? message.ActorId] = [message];
                else userMessages[message.FromId ?? message.ActorId].Add(message);
            }

            foreach (var messages in userMessages)
            {
                chat_users.Add(new User(messages.Key, messages.Value)); // messages.Key = name & messages.Value = список повідомлень message
            }
            return chat_users;
        }
        private Dictionary<string,UserMessagesData> TakeStatisticsALLUsers(List<User> users)
        {
            var statistics = new Dictionary<string,UserMessagesData>();
            foreach (var user in users)
            {
                if (!statistics.ContainsKey(user.Id)) statistics[user.Id] = TakeStatisticsUser(user);
                else continue;
            }
            return statistics;
        }
        private UserMessagesData TakeStatisticsUser(User user)
        {
            string name = user.Messages.FirstOrDefault(x => x.From != null).From ?? "unknown";
            uint messageCount = (uint)user.Messages.Count;
            uint messageCountPhoto = 0;
            uint messageCountCircleVideo = 0;
            uint messageCountVideo = 0;
            uint messageCountAudio = 0;
            uint messageCountVoice = 0;
            uint messageCountGIF = 0;
            uint messageCountSticker = 0;
            uint countPhoneCalls = 0;
            foreach (var messageType in user.Messages)
            {
                if (messageType.Photo!=null) messageCountPhoto++;
                if(messageType.Action == "phone_call") 
                    countPhoneCalls++;
                switch (messageType.MediaType) 
                {
                    case "sticker":
                        messageCountSticker++;
                        break;
                    case "voice_message":
                        messageCountVoice++;
                        break;
                    case "video_file":
                        messageCountVideo++;
                        break;
                    case "animation":
                        messageCountGIF++;
                        break;
                    case "video_message":
                        messageCountCircleVideo++;
                        break;
                    case "audio_file":
                        messageCountAudio++;
                        break;
                }
            }
            return new UserMessagesData
                (name, messageCount, messageCountPhoto, 
                messageCountCircleVideo, messageCountVideo, messageCountAudio, 
                messageCountVoice, messageCountGIF, messageCountSticker, countPhoneCalls);
        }

        private Message FindFirstUserMessage(List<Message> messages)
        {
            foreach (var message in messages) 
            {
                if(message.Text != "") return message;
            }
            return messages[0];
        }

        private Dictionary<int,int> TakeActiveByHours(DataChat chat)
        {
            var activeHours = new Dictionary<int, int>();
            foreach(Message message in chat.Messages)
            {
                int hour = message.Date.Value.Hour;
                if(!activeHours.ContainsKey(hour)) activeHours[hour] = 1;
                else activeHours[hour]++;
            }
            //double procent = Math.Round((double)activeHours[23] / chat.Messages.Count * 100, 2);
            return activeHours;
        }
    }
}
