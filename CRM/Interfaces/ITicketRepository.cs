using CRM.Model;


namespace CRM.Interfaces;

public interface ITicketRepository : IRepositoryBase<Ticket>
{
    Ticket GetTicketById(int ticketId);
    IEnumerable<Ticket> GetAllTickets();
    IEnumerable<Ticket> GetCustomerTickets(int id);
    IEnumerable<Ticket> GetTicketsReport(DateTime startDate, DateTime endDate);
    void CreateTicket(Ticket ticket);
    void UpdateTicket(Ticket ticket);
}
