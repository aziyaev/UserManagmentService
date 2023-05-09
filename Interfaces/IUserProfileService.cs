using IdentityService.Models;

namespace UserManagmentService.Interfaces
{
    public interface IUserProfileService
    {
        Task<User> GetUserAsync(int id);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
