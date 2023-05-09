using IdentityService.Models;
using UserManagmentService.Interfaces;

namespace UserManagmentService
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly UserProfileDbContext dbContext;

        public UserProfileRepository(UserProfileDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await dbContext.Users.FindAsync(id);
        }

        public async Task AddUserAsync(User user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            dbContext.Users.Update(user);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await dbContext.Users.FindAsync(id);
            dbContext.Users.Remove(user);
            await dbContext.SaveChangesAsync();
        }
    }
}
