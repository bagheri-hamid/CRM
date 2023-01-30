using CRM.Model;

namespace CRM.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetUserById(int id);
    }
}
