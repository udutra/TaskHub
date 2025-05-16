using TaskHub.Application.Interfaces;
using TaskHub.Domain.Entities;
using TaskHub.Domain.Repositories;

namespace TaskHub.Infrastructure.Persistence.Repositories;

public class UserRepository(TaskHubDbContext context) : IUserRepository{
    
    public async Task AddAsync(User user)
    {
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
    }

    public async Task<User?> GetByIdAsync(Guid id){
        return await context.Users.FindAsync(id);
    }
    
}