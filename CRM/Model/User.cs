using System;
using System.Collections.Generic;

namespace CRM.Model;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string? FullName { get; set; }

    public int? ContactInfo { get; set; }

    public string? Role { get; set; }
}
