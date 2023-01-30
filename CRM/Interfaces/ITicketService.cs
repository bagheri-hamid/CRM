using CRM.Model;
using CRM.Dtos;

namespace CRM.Interfaces;

public interface ITicketService
{
    IEnumerable<Ticket> GetTickets();
    IEnumerable<Ticket> GetCustomerTickets(int id);
    IEnumerable<Ticket> GetTicketsReport(DateTime startDate, DateTime endDate);
    int CreateTicket(TicketDto ticketDto);
    int AssignTicket(int teamMemberId, int ticketId);
    int CloseTicket(int ticketId);
    int ReopenTicket(int ticketId);
    int ResolveTicket(int ticketId);
}
