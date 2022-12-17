using ChatAppServer.DTO;
using ChatAppServer.Model;
using ChatAppServer.ServerSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatAppServer.Controller
{
    public class ChatController
    {
        private readonly Context _context;
        public ChatController()
        {
            _context = new Context();
        }
        public async Task<bool> ChatHandler(Base json, List<Worker> workers, Worker from)
        {
            switch(json.action.ToLower())
            {
                case "send":
                    {
                        var model = new ChatMessage().GetFromJson(json.content);
                        return await sendChat(model, workers, from);
                    }
                    break;
                case "getallmess":
                    {
                        var model = new GetByGroup().GetFromJson(json.content);
                        var response = new response { action = "getallmess", content = getAllMessage(model) };
                        from.Send(response.ParseToJson());
                        return true;
                    }
                    break;
                default: return false;
            }
            return false;
        }
        private async Task<bool> sendChat(ChatMessage mess, List<Worker> workers, Worker from)
        {
            try
            {
                var groupUsers = _context.GroupUsers.Where(x => x.GroupId == mess.GroupId).ToList();
                mess.ChatGroup = _context.ChatGroups.First(x => x.GroupId == mess.GroupId);
                mess.ChatUser = _context.ChatUsers.First(x => x.UserId == mess.CreatedBy);
                var message = new response { action = "newmess", content = mess.ParseToJson() };
                _context.ChatMessages.Add(mess);
                foreach (var user in groupUsers)
                {
                    if ((workers.Any(x => x.Username == user.UserId)) && user.UserId!=mess.CreatedBy) workers.First(x => x.Username == user.UserId).Send(message.ParseToJson());
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
                
        }
        private  string getAllMessage(GetByGroup model)
        {
            try
            {
                var mess = _context.ChatMessages.Where(x => x.GroupId == model.GroupID).ToList();
                var allmess = new AllMess { chatMessages = mess };
                if(mess!=null)
                {
                    var json = JsonSerializer.Serialize(allmess);
                    return json;
                }
                return null;
            } catch(Exception ex)
            {
                return "Something went wrong!";
            }
        }
    }
}
