using TaskHub.Domain.Entities;

namespace TaskHub.Infrastructure.Persistence;

public static class SeedData
{
    public static void Initialize(TaskHubDbContext context)
    {
        if (context.Users.Any()) return; // já foi populado

        var user = new User("Admin","admin@taskhub.com","Administrator");
        var team = new Team ("Equipe Inicial");

        context.Users.Add(user);
        context.Teams.Add(team);
        context.SaveChanges();
    }
}