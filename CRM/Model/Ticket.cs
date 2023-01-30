using System;
using System.Collections.Generic;
using System.Data;

namespace CRM.Model;

public partial class Ticket
{
    public int Id { get; set; }

    public string? Subject { get; set; }

    public string? CustomerId { get; set; }

    public int Status { get; set; }

    public int? TeamMemberId { get; set; }

    public string? Description { get; set; }

    public DateTime? RegisterDate { get; set; }

    public DateTime? FinishedDate { get; set; }

    public Ticket(string subject, string customerId, string description)
    {
        Subject = subject;
        CustomerId = customerId;
        Status = 1;
        Description = description;
        RegisterDate = DateTime.Now ;
    }
}
