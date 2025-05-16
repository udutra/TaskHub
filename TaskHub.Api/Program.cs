using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TaskHub.Application.Interfaces;
using TaskHub.Application.Services;
using TaskHub.Domain.Interfaces;
using TaskHub.Domain.Repositories;
using TaskHub.Infrastructure.Persistence;
using TaskHub.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "TaskHub API",
        Version = "v1",
        Description = "API do projeto TaskHub para gerenciamento de tarefas e equipes.",
        Contact = new OpenApiContact
        {
            Name = "Guilherme Galarça Dutra",
            Email = "udutra@gmail.com"
        }
    });
});

builder.Services.AddControllers();

builder.Services.AddDbContext<TaskHubDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

if (app.Environment.IsDevelopment()){
    using (var scope = app.Services.CreateScope()){
        var db = scope.ServiceProvider.GetRequiredService<TaskHubDbContext>();
        db.Database.Migrate();
        SeedData.Initialize(db);
    }
    
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskHub API v1");
        //options.RoutePrefix = string.Empty; // Deixa o Swagger na raiz: http://localhost:5000/
    });
    
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/", () => "Api OK!");

app.MapControllers();
app.Run();