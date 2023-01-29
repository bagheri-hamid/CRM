using CRM.Model;

namespace CRM.Interfaces;

public interface ITicketService
{
    IEnumerable<Ticket> GetTickets();
}
