using CRM.Application.Repository.Abstracts;
using CRM.Application.Services.Abstracts;
using CRM.Core.Entities;
using CRM.Dtos;

namespace CRM.Application.Services.Concretes;

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
    public IEnumerable<Ticket> GetTicketsReport(DateTime startDate, DateTime endDate)
    {
        return _repo.Ticket.GetTicketsReport(startDate, endDate);
    }
    public int CreateTicket(TicketDto ticketDto)
    {
        var customer = _repo.Customer.GetCustomerById(ticketDto.CustomerId);
        if (customer is null)
            return 1;

        var ticket = new Ticket(ticketDto.Subject, ticketDto.CustomerId.ToString(), ticketDto.Description);
        _repo.Ticket.CreateTicket(ticket);
        _repo.Save();
        return 0;
    }
    public IEnumerable<Ticket> GetCustomerTickets(int id)
    {
        return _repo.Ticket.GetCustomerTickets(id);
    }

    public int AssignTicket(int teamMemberId, int ticketId)
    {
        var teamMember = _repo.User.GetUserById(teamMemberId);
        if (teamMember is null)
            return 1;
        var ticket = _repo.Ticket.GetTicketById(ticketId);
        if (ticket is null)
            return 2;

        ticket.TeamMemberId = teamMemberId;
        ticket.Status = 2;
        _repo.Ticket.UpdateTicket(ticket);
        _repo.Save();
        return 0;
    }
    public int CloseTicket(int ticketId)
    {
        var ticket = _repo.Ticket.GetTicketById(ticketId);
        if (ticket is null)
            return 1;

        ticket.Status = 5;
        _repo.Ticket.UpdateTicket(ticket);
        _repo.Save();
        return 0;
    }
    public int ReopenTicket(int ticketId)
    {
        var ticket = _repo.Ticket.GetTicketById(ticketId);
        if (ticket is null)
            return 1;
        if (ticket.Status != 5)
            return 2;

        ticket.Status = 1;
        _repo.Ticket.UpdateTicket(ticket);
        _repo.Save();
        return 0;
    }
    public int ResolveTicket(int ticketId)
    {
        var ticket = _repo.Ticket.GetTicketById(ticketId);
        if (ticket is null)
            return 1;

        ticket.Status = 4;
        _repo.Ticket.UpdateTicket(ticket);
        _repo.Save();
        return 0;
    }
}
