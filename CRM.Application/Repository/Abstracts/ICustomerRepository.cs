using CRM.Core.Entities;

namespace CRM.Application.Repository.Abstracts
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        Customer GetCustomerById(int id);
    }
}
