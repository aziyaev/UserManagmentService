using IdentityService.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace UserManagmentService
{
    public class UserProfileDbContext : DbContext
    {
        public UserProfileDbContext(DbContextOptions<UserProfileDbContext> options) : base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
    }
}
