using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace project_nana
{
    public class Message
    {
        [JsonProperty("id")] public int? Id { get; private set; }
        [JsonProperty("date")] public DateTime? Date { get; private set; }
        [JsonProperty("from")] public string? From { get; private set; }
        [JsonProperty("from_id")] public string? FromId { get; private set; }
        [JsonProperty("text")] public object? Text { get; private set; }
        [JsonProperty("media_type")] public string? MediaType { get; private set; }
        [JsonProperty("photo")] public string? Photo { get; private set; }
        [JsonProperty("action")] public string? Action { get; private set; }
        [JsonProperty("text_entities")] public TextEntity[]? TextEntities { get; private set; }
        [JsonProperty("actor_id")] public string? ActorId { get; private set; }
        public class TextEntity
        {
            [JsonProperty("text")] public string? Text { get; private set; }
        }
        public static List<Message> FixJArrayInText(List<Message> chatMessages)
        {
            foreach (var message in chatMessages)
            {
                if (message.Text is JArray textJArray)
                {
                    message.Text = "";
                    foreach (var messageEntity in message.TextEntities)
                    {
                        message.Text += messageEntity.Text;
                    }
                }
            }
            return chatMessages;
        }
    }
}
