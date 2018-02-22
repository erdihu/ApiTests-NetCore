namespace ApiDotNetCore.Models.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public UserDto(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }
    }
}
