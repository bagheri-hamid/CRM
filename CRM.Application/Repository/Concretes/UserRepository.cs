using CRM.Application.Repository.Abstracts;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Concretes
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(CrmContext crmContext)
            : base(crmContext)
        {
        }

        public User GetUserById(int id)
        {
            return FindByCondition(us => us.Id.Equals(id)).FirstOrDefault();
        }
    }
}