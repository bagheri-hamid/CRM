using CRM.Application.Repository.Abstracts;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Concretes
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