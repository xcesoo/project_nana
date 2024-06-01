namespace project_nana
{
    public class User
    {
        public User(string? id, List<Message>? messages)
        {
            Id = id;
            Messages = messages;
        }

        public string? Id { get; }
        public List<Message>? Messages { get; }
    }
}
