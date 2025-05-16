using FluentAssertions;
using Moq;
using TaskHub.Application.Interfaces;
using TaskHub.Application.Requests;
using TaskHub.Application.Services;
using TaskHub.Domain.Entities;
using TaskHub.Domain.Interfaces;
using TaskHub.Domain.Repositories;

namespace TaskHub.UnitTests.Services;

public class UserServiceTests{
    
    private readonly Mock<IUnitOfWork> _unitOfWorkMock;
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly UserService _userService;

    public UserServiceTests(){
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _userRepositoryMock = new Mock<IUserRepository>();
        _unitOfWorkMock.SetupGet(u => u.Users).Returns(_userRepositoryMock.Object);
        _userService = new UserService(_unitOfWorkMock.Object);
    }

    [Fact]
    public async Task CreateUserAsync_Should_Create_User_And_Return_Id(){
        
        // Arrange
        var request = new CreateUserRequest{
            UserName = "udutra",
            Email = "udutra@gmail.com",
            FullName = "Guilherme Dutra"
        };

        _userRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<User>())).Returns(Task.CompletedTask);
        _unitOfWorkMock.Setup(uow => uow.CommitAsync()).ReturnsAsync(1);

        // Act
        var userId = await _userService.CreateUserAsync(request);

        // Assert
        userId.Should().NotBeEmpty();
        _userRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<User>()), Times.Once);
        _unitOfWorkMock.Verify(uow => uow.CommitAsync(), Times.Once);
    }
}