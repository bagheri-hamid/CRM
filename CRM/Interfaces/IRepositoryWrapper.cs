namespace CRM.Interfaces;

public interface IRepositoryWrapper
{
    ITicketRepository Ticket { get; }
    void Save();
}