using CRM.Core.Entities;

namespace CRM.Application.Repository.Abstracts;

public interface ITicketRepository : IRepositoryBase<Ticket>
{
    Ticket GetTicketById(int ticketId);
    IEnumerable<Ticket> GetAllTickets();
    IEnumerable<Ticket> GetCustomerTickets(int id);
    IEnumerable<Ticket> GetTicketsReport(DateTime startDate, DateTime endDate);
    void CreateTicket(Ticket ticket);
    void UpdateTicket(Ticket ticket);
}
