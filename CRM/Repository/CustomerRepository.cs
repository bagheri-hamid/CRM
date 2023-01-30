using CRM.Interfaces;
using CRM.Model;

namespace CRM.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(CrmContext crmContext)
            : base(crmContext)
        {
        }

        public Customer GetCustomerById(int id)
        {
            return FindByCondition(c => c.Id.Equals(id)).FirstOrDefault();
        }
    }
}