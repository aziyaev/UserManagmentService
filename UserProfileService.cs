using IdentityService.Models;
using UserManagmentService.Interfaces;

namespace UserManagmentService
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository userRepository;

        public UserProfileService(UserProfileRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await userRepository.GetUserAsync(id);
        }

        public async Task UpdateUserAsync(User user)
        {
            await userRepository.UpdateUserAsync(user);
        }

        public async Task AddUserAsync(User user)
        {
            await userRepository.AddUserAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await userRepository.DeleteUserAsync(id);
        }
    }
}
