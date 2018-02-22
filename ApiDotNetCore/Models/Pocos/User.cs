using ApiDotNetCore.Models.Dto;

namespace ApiDotNetCore.Models.Pocos
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public UserDto GetUserDto()
        {
            return new UserDto(UserId, Name);
        }
    }
}
