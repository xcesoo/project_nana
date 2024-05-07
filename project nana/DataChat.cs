using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_nana
{
    public class DataChat
    {
        public DataChat(string? name, string? type, ulong? id, Message[]? messages)
        {
            Name = name;
            Type = type;
            Id = id;
            Messages = messages;
        }

        public string? Name { get; }
        public string? Type { get; }
        public ulong? Id { get; }
        public Message[]? Messages { get; }

    }
}
