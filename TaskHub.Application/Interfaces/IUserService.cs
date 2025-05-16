using TaskHub.Application.DTOs;
using TaskHub.Application.Requests;

namespace TaskHub.Application.Interfaces;

public interface IUserService{
    Task<Guid> CreateUserAsync(CreateUserRequest request);
    Task<UserDto> GetByIdAsync(Guid id);
}