using Domain.Entities;

namespace Domain.Ports;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<User> AddNewUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<User> DeleteUserAsync(Guid id);
}
