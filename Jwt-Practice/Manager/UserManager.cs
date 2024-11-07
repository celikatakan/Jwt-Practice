using Jwt_Practice.Context;
using Jwt_Practice.Dtos;
using Jwt_Practice.Entities;
using Jwt_Practice.Services;
using Jwt_Practice.Types;

namespace Jwt_Practice.Manager
{
    public class UserManager : IUserService
    {
        private readonly CustomIdentityDbContext _dbContext;

        public UserManager(CustomIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<ServiceMessage> AddUser(AddUserDto user)
        {
            var newUser = new UserEntity
            {
                Email = user.Email,
                Password = user.Password,
            };

            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            return new ServiceMessage
            {
                IsSucceed = true,
                Message = "The registration was successful."
            };

        }

        public async Task<ServiceMessage<UserInfoDto>> LoginUser(LoginUserDto user)
        {
            var userEntity = _dbContext.Users.Where(x => x.Email.ToLower() == user.Email.ToLower()).FirstOrDefault();

            if (userEntity is null)
            {
                return new ServiceMessage<UserInfoDto>
                {
                    IsSucceed = false,
                    Message = "Wrong Email or Password."
                };
            }

            if (userEntity.Password == user.Password)
            {
                return new ServiceMessage<UserInfoDto>
                {
                    IsSucceed = true,
                    Data = new UserInfoDto
                    {
                        Id = userEntity.Id,
                        Email = userEntity.Email,
                        UserType = userEntity.UserType
                    }
                };
            }
            else
            {
                return new ServiceMessage<UserInfoDto>
                {
                    IsSucceed = false,
                    Message = "Wrong Email or Password."
                };
            }
        }
    }
}
