using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using TaskHub.Domain.Entities;
using TaskHub.Infrastructure.Persistence.Repositories;

namespace TaskHub.IntegrationTests.Users;

public class UserRepositoryIntegrationTests{
    
    [Fact]
    public async Task AddUser_ShouldPersistUser(){
        // Arrange
        await using var context = TaskHubDbContextFactory.CreateInMemoryDbContext();
        var repository = new UserRepository(context);

        var user = new User("udutra", "udutra@gmail.com","Guilherme Dutra");

        // Act
        await repository.AddAsync(user);
        await context.SaveChangesAsync();

        // Assert
        var users = await context.Users.ToListAsync();
        users.Should().ContainSingle(u => u.Email == "udutra@gmail.com");
    }
}