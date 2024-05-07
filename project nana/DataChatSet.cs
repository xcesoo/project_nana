using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_nana
{
    class DataChatSet
    {
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("type")] public string? Type { get; set; }
        [JsonProperty("id")] public ulong? Id { get; set; }
        [JsonProperty("messages")] public Message[]? Messages { get; set; }
        public static DataChat CreateNewDataChat(string json)
        {
            DataChatSet chatSet = JsonConvert.DeserializeObject<DataChatSet>(json);
            FixJArrayInText(chatSet);
            return new DataChat(chatSet.Name,chatSet.Type, chatSet.Id, chatSet.Messages);
        }
        private static void FixJArrayInText(DataChatSet chatSet)
        {
            foreach(var message in chatSet.Messages)
            {
                if(message.Text is JArray textJArray)
                {
                    message.Text = "";
                    foreach(var messageEntity in message.TextEntities) 
                    {
                        message.Text += messageEntity.Text;
                    }
                }
            }
        }
    }
}
