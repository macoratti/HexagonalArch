using Domain.Adapters;
using Domain.Entities;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly InMemoryContext _context;

    public UserRepository(InMemoryContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<User>> GetAll()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> Insert(User user)
    {
        if (user is null)
        {
            throw new ArgumentNullException(nameof(user));
        }

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<User> Update(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<User> Delete(Guid id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

        if (user is null)
        {
            throw new ArgumentNullException(nameof(user));
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return user;
    }
}
