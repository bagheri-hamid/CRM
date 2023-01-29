using CRM.Interfaces;
using CRM.Model;

namespace CRM.Repository;

public class RepositoryWrapper : IRepositoryWrapper
{
    private CrmContext _repoContext;
    private ITicketRepository _ticket;

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


    public RepositoryWrapper(CrmContext crmContext)
    {
        _repoContext = crmContext;
    }

    public void Save()
    {
        _repoContext.SaveChanges();
    }
}