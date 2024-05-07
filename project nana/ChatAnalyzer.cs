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
            List<string> text = chat.Messages?.Select(x => (string)x.Text).ToList() ?? new List<string>();
            List<User> users = AnalyzeUsers(chat);
            return new ChatAnalyzerResult(users, textAnalyzer.Analyze(text), TakeStatisticsALLUsers(users));
        }
        private List<User> AnalyzeUsers(DataChat chat) 
        {
            List<User> chat_users = new List<User>();
            var userMessages = new Dictionary<string, List<Message>>();
            foreach (var message in chat.Messages)
            {
                if (message.FromId == null) continue;
                if (!userMessages.ContainsKey(message.FromId)) userMessages[message.FromId] = [message];
                else userMessages[message.FromId].Add(message);
            }

            foreach (var messages in userMessages)
            {
                chat_users.Add(new User()
                {
                    id = messages.Key,
                    messages = messages.Value
                });
            }
            return chat_users;
        }
        private Dictionary<string,UserMessagesData> TakeStatisticsALLUsers(List<User> users)
        {
            var statistics = new Dictionary<string,UserMessagesData>();
            foreach (var user in users)
            {
                if (!statistics.ContainsKey(user.id)) statistics[user.id] = TakeStatisticsUser(user);
                else continue;
            }
            return statistics;
        }
        private UserMessagesData TakeStatisticsUser(User user)
        {
            string name = user.messages[0].From;
            uint messageCount = (uint)user.messages.Count;
            uint messageCountPhoto = 0;
            uint messageCountCircleVideo = 0;
            uint messageCountVideo = 0;
            uint messageCountAudio = 0;
            uint messageCountVoice = 0;
            uint messageCountGIF = 0;
            uint messageCountSticker = 0;
            uint countPhoneCalls = 0;
            foreach (var messageType in user.messages)
            {
                if (messageType.Photo!=null) messageCountPhoto++;
                if(messageType.Action == "phone_call") countPhoneCalls++;
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
    }
}
