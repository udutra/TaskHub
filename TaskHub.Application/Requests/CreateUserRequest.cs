namespace TaskHub.Application.Requests;

public class CreateUserRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
}