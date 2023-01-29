using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRM.Model;

public partial class CrmContext : DbContext
{
    public CrmContext()
    {
    }

    public CrmContext(DbContextOptions<CrmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ContactInfo> ContactInfos { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }
}
