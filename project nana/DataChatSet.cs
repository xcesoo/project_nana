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
        [JsonProperty("name")] public string? Name { get; private set; }
        [JsonProperty("type")] public string? Type { get; private set; }
        [JsonProperty("id")] public ulong? Id { get; private set; }
        [JsonProperty("messages")] public List<Message>? Messages { get; private set; }
        public static DataChat CreateNewDataChat(string json)
        {
            DataChatSet chatSet = JsonConvert.DeserializeObject<DataChatSet>(json);
            chatSet.Messages = Message.FixJArrayInText(chatSet.Messages);
            return new DataChat(chatSet.Name,chatSet.Type, chatSet.Id, chatSet.Messages);
        }
    }
}
