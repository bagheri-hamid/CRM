using CRM.Interfaces;
using CRM.Model;

namespace CRM.Repository
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