using CRM.Model;


namespace CRM.Interfaces;

public interface ITicketRepository : IRepositoryBase<Ticket>
{
    IEnumerable<Ticket> GetAllTickets();
}
