using System;
using System.Collections.Generic;

namespace CRM.Model;

public partial class TicketStatus
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;
}
