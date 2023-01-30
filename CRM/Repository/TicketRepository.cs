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

        public Ticket GetTicketById(int ticketId)
        {
            return FindByCondition(t => t.Id.Equals(ticketId)).FirstOrDefault();
        }

        public IEnumerable<Ticket> GetTicketsReport(DateTime startDate, DateTime endDate)
        {
            return  FindAll()
                    .Where(t => t.RegisterDate >= startDate && t.RegisterDate <= endDate)
                    .ToList();
        }

        public void CreateTicket(Ticket ticket) {
            Create(ticket);
        }

        public IEnumerable<Ticket> GetCustomerTickets(int id)
        {
            return FindAll().Where(ticket => ticket.CustomerId == id.ToString());
        }

        public void UpdateTicket(Ticket ticket)
        {
            Update(ticket);
        }
    }
}