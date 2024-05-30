using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_nana
{
    class ChatAnalyzerResult
    {
        public ChatAnalyzerResult
            (
            List<User> chatUsers, 
            TextAnalyzerResult textAnalyzerResult, 
            Dictionary<string, 
            UserMessagesData> userMessageData, 
            Message firstChatMessage, 
            Dictionary<int,int> activeHours)
        {
            ChatUsers = chatUsers;
            TextAnalyzerResult = textAnalyzerResult;
            UserMessagesData = userMessageData;
            FirstChatMessage = firstChatMessage;
            ActiveHours = activeHours;
        }
        public List<User> ChatUsers { get; }
        public TextAnalyzerResult TextAnalyzerResult { get; }
        public Dictionary<string, UserMessagesData> UserMessagesData { get; }
        public Message FirstChatMessage { get; }
        public Dictionary<int, int> ActiveHours { get; }
    }

    public class UserMessagesData
    {
        public UserMessagesData
            (string name, uint messageCount, uint messageCountPhoto, 
            uint messageCountCircleVideo, uint messageCountVideo, uint messageCountAudio, 
            uint messageCountVoice, uint messageCountGIF, uint messageCountSticker, uint countPhoneCalls)
        {
            Name = name;
            MessageCount = messageCount;
            MessageCountPhoto = messageCountPhoto;
            MessageCountCircleVideo = messageCountCircleVideo;
            MessageCountVideo = messageCountVideo;
            MessageCountAudio = messageCountAudio;
            MessageCountVoice = messageCountVoice;
            MessageCountGIF = messageCountGIF;
            MessageCountSticker = messageCountSticker;
            CountPhoneCalls = countPhoneCalls;
        }

        public string Name { get; }
        public uint MessageCount { get; }
        public uint MessageCountPhoto {  get; }
        public uint MessageCountCircleVideo { get; }
        public uint MessageCountVideo { get; }
        public uint MessageCountAudio { get; }
        public uint MessageCountVoice { get; }
        public uint MessageCountGIF { get; }
        public uint MessageCountSticker {  get; }
        public uint CountPhoneCalls {  get; }
    }
}
