namespace CRM.Interfaces;

public interface IRepositoryWrapper
{
    ITicketRepository Ticket { get; }
    ICustomerRepository Customer { get; }
    IUserRepository User { get; }
    INoteRepository Note { get; }
    void Save();
}