using System;
using System.Text.Json;

namespace ChapAppClient.DTO
{
    public class AddFriendDTO
    {
        public Guid userId { get; set; }
        public string userName { get; set; }
        public string name { get; set; }

        public string ParseToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public AddFriendDTO GetFromJson(string json)
        {
            return JsonSerializer.Deserialize<AddFriendDTO>(json);
        }
    }
}
