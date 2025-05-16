using TaskHub.Application.DTOs;
using TaskHub.Application.Interfaces;
using TaskHub.Application.Requests;
using TaskHub.Domain.Entities;
using TaskHub.Domain.Interfaces;

namespace TaskHub.Application.Services;

public class UserService(IUnitOfWork unitOfWork) : IUserService{
    
    public async Task<Guid> CreateUserAsync(CreateUserRequest request)
    {
        var user = new User(request.UserName, request.Email, request.FullName);
        await unitOfWork.Users.AddAsync(user);
        await unitOfWork.CommitAsync();
        return user.Id;
    }

    public async Task<UserDto> GetByIdAsync(Guid id)
    {
        var user = await unitOfWork.Users.GetByIdAsync(id) ?? throw new Exception("Usuário não encontrado");

        return new UserDto{
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            FullName = user.FullName
        };
    }
}