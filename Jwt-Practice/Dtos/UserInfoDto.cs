using Jwt_Practice.Entities;

namespace Jwt_Practice.Dtos
{
    public class UserInfoDto
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public UserType UserType { get; set; }
    }
}
