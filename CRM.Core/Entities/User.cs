namespace CRM.Core.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string? FullName { get; set; }

    public int? ContactInfo { get; set; }

    public int Role { get; set; }

    public User(string username, string fullname , int role)
    {
        Username = username;
        FullName = fullname;
        Role = role;
    }
    public User(int id, string username, string fullname, int role)
    {
        Id = id;
        Username = username;
        FullName = fullname;
        Role = role;
    }

    public User() { }
}
