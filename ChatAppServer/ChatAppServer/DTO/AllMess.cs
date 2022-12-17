using ChatAppServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatAppServer.DTO
{
    public class AllMess
    {
        public List<ChatMessage> chatMessages { get; set; }
        public string ParseToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public AllMess GetFromJson(string json)
        {
            return JsonSerializer.Deserialize<AllMess>(json);
        }
    }
}
