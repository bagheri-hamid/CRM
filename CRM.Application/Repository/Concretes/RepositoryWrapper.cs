using CRM.Application.Repository.Abstracts;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Concretes;

public class RepositoryWrapper : IRepositoryWrapper
{
    private CrmContext _repoContext;
    private ITicketRepository _ticket;
    private ICustomerRepository _customer;
    private IUserRepository _user;
    private INoteRepository _note;
    private INotificationRepository _notification;

    public ITicketRepository Ticket
    {
        get
        {
            if (_ticket == null)
            {
                _ticket = new TicketRepository(_repoContext);
            }

            return _ticket;
        }
    }
    public ICustomerRepository Customer
    {
        get
        {
            if (_customer == null)
            {
                _customer = new CustomerRepository(_repoContext);
            }

            return _customer;
        }
    }

    public IUserRepository User
    {
        get
        {
            if (_user == null)
            {
                _user = new UserRepository(_repoContext);
            }

            return _user;
        }
    }
    public INoteRepository Note
    {
        get
        {
            if (_note == null)
            {
                _note = new NoteRepository(_repoContext);
            }

            return _note;
        }
    }
    public INotificationRepository Notification
    {
        get
        {
            if (_notification == null)
            {
                _notification = new NotificationRepository(_repoContext);
            }

            return _notification;
        }
    }
    public RepositoryWrapper(CrmContext crmContext)
    {
        _repoContext = crmContext;
    }

    public void Save()
    {
        _repoContext.SaveChanges();
    }
}