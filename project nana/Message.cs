using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace project_nana
{
    public class Message
    {
        [JsonProperty("id")] public int? Id { get; set; }
        [JsonProperty("date")] public DateTime? Date { get; set; }
        [JsonProperty("from")] public string? From { get; set; }
        [JsonProperty("from_id")] public string? FromId { get; set; }
        [JsonProperty("text")] public object? Text { get; set; }
        [JsonProperty("media_type")] public string? MediaType { get; set; }
        [JsonProperty("photo")] public string? Photo { get; set; }
        [JsonProperty("action")] public string? Action { get; set; }
        [JsonProperty("text_entities")] public TextEntity[]? TextEntities { get; set; }
        public class TextEntity
        {
            [JsonProperty("text")] public string? Text { get; set; }
        }
    }
}
