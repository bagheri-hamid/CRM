using System;
using System.Collections.Generic;

namespace CRM.Model;

public partial class Customer
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public int? ContactInfo { get; set; }
}
