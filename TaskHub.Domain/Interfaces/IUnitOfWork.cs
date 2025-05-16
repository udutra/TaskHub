using TaskHub.Domain.Repositories;

namespace TaskHub.Domain.Interfaces;

public interface IUnitOfWork{
    
    IUserRepository Users { get; }

    Task<int> CommitAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}