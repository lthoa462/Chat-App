using ChapAppClient.DTO;
using ChatAppServer.DTO;
using ChatAppServer.Model;
using ChatAppServer.ServerSocket;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatAppServer.Controller
{
    public class UserController
    {
        private readonly Context _context;

        public UserController()
        {
            _context = new Context();
        }

        public async void UserHandler(Base json, List<Worker> workers, Worker from)
        {
            switch (json.action.ToLower())
            {
                case "login":
                {
                    var model = new Login().GetFromJson(json.content);
                    var response = new response { action = "login", content =await Login(model, from) };
                    from.Send(response.ParseToJson());
                    break;
                }
                case "register":
                {
                    var model = new ChatUser().GetFromJson(json.content);
                    var response = new response { action = "register", content = SignUp(model).Result };
                    from.Send(response.ParseToJson());
                    break;
                }

                case "get":
                {
                    var model = new GetUser().GetFromJson(json.content);
                    var response = new response { action = "get", content = Get(model).Result };
                    from.Send(response.ParseToJson());
                    break;
                }
                case "getbyname":
                {
                    var model = new GetUserByName().GetFromJson(json.content);
                    var response = new response { action = "getbyname", content = GetUserByName(model).Result };
                    from.Send(response.ParseToJson());
                    break;
                }

                case "changepass":
                {
                    var model = new ChangePass().GetFromJson(json.content);
                    var response = new response { action = "changepass", content = ChangePage(model).Result };
                    break;
                }
                case "addfriend":
                    {
                        var model = JsonSerializer.Deserialize<AddFriendRequestDTO>(json.content);
                        var response = new response { action = "getbyname", content = SendAddFriendRequest(model).Result };
                        from.Send(response.ParseToJson());
                        break;
                    }
                default:
                    break;
            }
        }

        private async Task<string> Login(Login model,  Worker from)
        {
            var user = await _context.ChatUsers.FirstOrDefaultAsync(x => x.UserName == model.UserName && x.Password == model.Password);
            if (user == null)
            {
                return "login failed";
            }
            else
            {
                from.Username = user.UserId;
                return user.ParseToJson();
            }
        }

        private async Task<string> SignUp(ChatUser model)
        {
            try
            {
                if (_context.ChatUsers.Any(x => x.UserName == model.UserName)) return "account conflict";
                _context.ChatUsers.Add(model);
                await _context.SaveChangesAsync();
                return "successfully created";
            }
            catch (Exception ex)
            {
                return "something went wrong";
            }
        }

        private async Task<string> Get(GetUser model)
        {
            if (!_context.ChatUsers.Any(x => x.UserName == model.UserName)) return "user is not exist";
            var user = _context.ChatUsers.FirstOrDefault(x => x.UserName == model.UserName);
            return user.ParseToJson();
        }

        private async Task<string> GetUserByName(GetUserByName model)
        {
            var users = _context.ChatUsers.Where(x => x.Name.Contains(model.Name)).ToList();
            return JsonSerializer.Serialize(users);
        }

        private async Task<string> ChangePage(ChangePass model)
        {
            try
            {
                if (_context.ChatUsers.Any(x => x.UserName == model.UserName))
                {
                    var user = _context.ChatUsers.First(x => x.UserName == model.UserName);
                    if (user.Password != model.CurrentPass) return "your current password is wrong";
                    _context.ChatUsers.Remove(user);
                    user.Password = model.CurrentPass;
                    _context.ChatUsers.Add(user);
                    await _context.SaveChangesAsync();
                    return "Your password changed";
                }
                else
                    return "something went wrong";
            }
            catch (Exception ex)
            {
                return "some thing went wrong, please contact your admin";
            }
        }

        private async Task<string> SendAddFriendRequest(AddFriendRequestDTO model)
        {
            if(model.members.Count == 1)
            {
                var requestUser = await _context.ChatUsers.FirstOrDefaultAsync(u => u.UserId == model.userRequestId);
                List<GroupUser> groupUsers = await _context.GroupUsers
                                            .Where(x => x.UserId == model.userRequestId || x.UserId == model.members.ElementAt(0).userId)
                                            .ToListAsync();
                if(groupUsers.GroupBy(x => x.GroupId).Any(group => group.Count() == 2)){
                    return $"{model.members.ElementAt(0).name} is friend already";
                }else
                {
                    ChatGroup newGroup = new ChatGroup();
                    newGroup.GroupId = Guid.NewGuid();
                    newGroup.CreatedBy = model.userRequestId;
                    newGroup.CreatedDate = DateTime.Now;
                    newGroup.GroupName = $"{model.members.ElementAt(0).name + "," + requestUser.Name}";

                    _context.ChatGroups.Add(newGroup);
                    _context.GroupUsers.Add(new GroupUser
                    {
                        GroupId = newGroup.GroupId,
                        UserId = model.userRequestId,
                        isApprove = true
                    });
                    _context.GroupUsers.Add(new GroupUser
                    {
                        GroupId = newGroup.GroupId,
                        UserId = model.members.ElementAt(0).userId,
                        isApprove = true
                    });
                    InviteUser(model.members.ElementAt(0));
                    await _context.SaveChangesAsync();
                    return JsonSerializer.Serialize(newGroup);
                }
            }else
            {
                ChatGroup newGroup = new ChatGroup();
                newGroup.GroupId = Guid.NewGuid();
                newGroup.CreatedBy = model.userRequestId;
                newGroup.CreatedDate = DateTime.Now;
                List<string> memberNames = new List<string>();

                _context.GroupUsers.Add(new GroupUser
                {
                    GroupId = newGroup.GroupId,
                    UserId = model.userRequestId,
                    isApprove = true
                });
                foreach (AddFriendDTO user in model.members)
                {
                    _context.GroupUsers.Add(new GroupUser
                    {
                        GroupId = newGroup.GroupId,
                        UserId = user.userId,
                        isApprove = true
                    });
                    memberNames.Add(user.name);
                    InviteUser(user);
                }
                newGroup.GroupName = String.Join(",", memberNames);
                _context.ChatGroups.Add(newGroup);
                await _context.SaveChangesAsync();
                return JsonSerializer.Serialize(newGroup);
            }
        }

        private void InviteUser(AddFriendDTO user)
        {

        }
    }
}