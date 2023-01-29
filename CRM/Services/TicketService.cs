using CRM.Interfaces;
using CRM.Model;

namespace CRM.Services;

public class TicketService : ITicketService
{
    private readonly IRepositoryWrapper _repo;

    public TicketService(IRepositoryWrapper repo)
    {
        _repo = repo;
    }

    public IEnumerable<Ticket> GetTickets()
    {
        return _repo.Ticket.GetAllTickets();
    }
}
