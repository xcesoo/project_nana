using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_nana
{
    public class User
    {
        public string? id { get; set; } 
        public string? name { get; set; } 
        public List<Message>? messages { get; set; }
        public int msg_count { get; set; }
        public int msg_type_photo { get; set; }
        public int msg_type_circle_video { get; set; }
        public int msg_type_video { get; set; }
        public int msg_type_audio { get; set; }
        public int msg_type_voice { get; set; }
        public int msg_type_GIF { get; set; }
        public int msg_type_sticker { get; set; }
        public int count_phone_calls { get; set; }
    }

   
}
