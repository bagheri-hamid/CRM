using CRM.Model;

namespace CRM.Interfaces
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        Customer GetCustomerById(int id);
    }
}
