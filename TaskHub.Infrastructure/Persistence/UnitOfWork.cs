using Microsoft.EntityFrameworkCore.Storage;
using TaskHub.Domain.Interfaces;
using TaskHub.Domain.Repositories;

namespace TaskHub.Infrastructure.Persistence;

public class UnitOfWork(TaskHubDbContext context, IUserRepository userRepository) : IUnitOfWork{
    
    private IDbContextTransaction? _transaction;
    public IUserRepository Users{ get; } = userRepository;

    public async Task<int> CommitAsync(){
        return await context.SaveChangesAsync();
    }

    public async Task BeginTransactionAsync(){
        _transaction ??= await context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync(){
        if (_transaction != null){
            await _transaction.CommitAsync();
            await _transaction.DisposeAsync();
            _transaction = null;
        }
    }

    public async Task RollbackTransactionAsync(){
        if (_transaction != null)
        {
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
            _transaction = null;
        }
    }

    public void Dispose(){
        context.Dispose();
    }
}