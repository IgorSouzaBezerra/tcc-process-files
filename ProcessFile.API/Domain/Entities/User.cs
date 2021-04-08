using ProcessFile.API.Domain.Enum;

namespace ProcessFile.API.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
