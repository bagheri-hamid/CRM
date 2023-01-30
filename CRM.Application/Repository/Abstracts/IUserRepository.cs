using CRM.Core.Entities;

namespace CRM.Application.Repository.Abstracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetUserById(int id);
    }
}
