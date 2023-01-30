namespace CRM.Core.Dtos.User;

public class UserDto
{
    public string Username { get; set; } = null!;

    public string? FullName { get; set; }

    public int? Role { get; set; }
}
