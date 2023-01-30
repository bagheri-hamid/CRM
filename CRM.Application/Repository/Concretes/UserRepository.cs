using CRM.Application.Repository.Abstracts;
using CRM.Core.Dtos;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Concretes
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(CrmContext crmContext)
            : base(crmContext)
        {
        }

        public IEnumerable<User> GetAll()
        {
            return FindAll().ToList();
        }

        public User GetUserById(int id)
        {
            return FindByCondition(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public User GetUserByUsername(string username)
        {
            return FindByCondition(u => u.Username.Equals(username)).FirstOrDefault();
        }

    }
}