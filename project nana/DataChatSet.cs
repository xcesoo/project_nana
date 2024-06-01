using Newtonsoft.Json;

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
            if (chatSet.Name == null && chatSet.Type == null && chatSet.Id == null && chatSet.Messages == null) throw new Exception();
            chatSet.Messages = Message.FixJArrayInText(chatSet.Messages);
            return new DataChat(chatSet.Name, chatSet.Type, chatSet.Id, chatSet.Messages);
        }
    }
}
