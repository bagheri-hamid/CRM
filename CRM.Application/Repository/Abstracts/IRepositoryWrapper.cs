namespace CRM.Application.Repository.Abstracts;

public interface IRepositoryWrapper
{
    ITicketRepository Ticket { get; }
    ICustomerRepository Customer { get; }
    IUserRepository User { get; }
    INoteRepository Note { get; }
    void Save();
}