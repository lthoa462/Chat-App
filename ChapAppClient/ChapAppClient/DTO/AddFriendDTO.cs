using System;
using System.Text.Json;

namespace ChapAppClient.DTO
{
    public class AddFriendDTO
    {
        public Guid userId;
        public string userName;
        public string name;

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
