using Microsoft.EntityFrameworkCore;
using TaskHub.Infrastructure.Persistence;

namespace TaskHub.IntegrationTests;

public static class TaskHubDbContextFactory{
    public static TaskHubDbContext CreateInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<TaskHubDbContext>()
            .UseSqlite("Filename=:memory:")
            .Options;

        var context = new TaskHubDbContext(options);
        context.Database.OpenConnection();    // necessário para SQLite in-memory
        context.Database.EnsureCreated();

        return context;
    }
}