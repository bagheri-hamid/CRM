using CRM.Interfaces;
using CRM.Model;

namespace CRM.Repository
{
    public class TicketRepository : RepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(CrmContext crmContext)
            : base(crmContext)
        {
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return FindAll().ToList();
        }
    }
}