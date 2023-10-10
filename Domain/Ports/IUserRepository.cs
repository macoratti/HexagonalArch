using Domain.Entities;

namespace Domain.Adapters;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAll();
    Task<User> Insert(User user);
    Task<User> Update(User user);
    Task<User> Delete(Guid id);
}
