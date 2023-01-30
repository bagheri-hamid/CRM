using CRM.Core.Entities;

namespace CRM.Application.Repository.Abstracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetAll();
        User GetUserById(int id);
        User GetUserByUsername(string username);
    }
}
