namespace CRM.Model;

public partial class ContactInfo
{
    public int Id { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string Email { get; set; } = null!;
}
