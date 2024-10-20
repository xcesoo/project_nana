﻿namespace project_nana
{
    public class DataChat
    {
        public DataChat(string? name, string? type, ulong? id, List<Message>? messages)
        {
            Name = name;
            Type = type;
            Id = id;
            Messages = messages;
        }

        public string? Name { get; }
        public string? Type { get; }
        public ulong? Id { get; }
        public List<Message>? Messages { get; }
    }
}
