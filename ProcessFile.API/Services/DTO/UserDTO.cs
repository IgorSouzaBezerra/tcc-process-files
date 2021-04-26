
using Newtonsoft.Json;
using ProcessFile.API.Domain.Enum;

namespace ProcessFile.API.Services.DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [JsonIgnore]
        public string OldPassword { get; set; }

        public string Avatar { get; set; }
        public UserStatus UserStatus { get; set; }

        public UserDTO()
        {}

        public UserDTO(long id, string name, string email, string password, string oldPassword)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.OldPassword = oldPassword;
        }

        public UserDTO(long id, string name, string email, string password, string oldPassword, UserStatus userStatus)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.OldPassword = oldPassword;
            this.UserStatus = userStatus;
        }

        public UserDTO(long id, string name, string email, string password, string oldPassword, string avatar, UserStatus userStatus)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.OldPassword = oldPassword;
            this.Avatar = avatar;
            this.UserStatus = userStatus;
        }
    }
}