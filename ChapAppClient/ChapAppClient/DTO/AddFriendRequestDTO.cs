using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChapAppClient.DTO
{
    public class AddFriendRequestDTO
    {
        public List<AddFriendDTO> members { get; set; }

        public Guid userRequestId { get; set; }

        public string ParseToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public AddFriendRequestDTO GetFromJson(string json)
        {
            return JsonSerializer.Deserialize<AddFriendRequestDTO>(json);
        }
    }
}
