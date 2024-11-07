using Jwt_Practice.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Jwt_Practice.Context
{
    public class CustomIdentityDbContext : DbContext
    {
        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}

