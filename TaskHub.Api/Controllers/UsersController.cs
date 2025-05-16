using Microsoft.AspNetCore.Mvc;
using TaskHub.Application.Interfaces;
using TaskHub.Application.Requests;

namespace TaskHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IUserService userService) : ControllerBase{
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request){
        var id = await userService.CreateUserAsync(request);
        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id){
        var user = await userService.GetByIdAsync(id);
        return Ok(user);
    }
}