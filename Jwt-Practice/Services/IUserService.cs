using Jwt_Practice.Dtos;
using Jwt_Practice.Types;

namespace Jwt_Practice.Services
{
    public interface IUserService
    {
        Task<ServiceMessage> AddUser(AddUserDto user);
        Task<ServiceMessage<UserInfoDto>> LoginUser(LoginUserDto user);
    }
}
