using CRM.Core.Dtos.User;
using CRM.Core.Entities;

namespace CRM.Application.Services.Abstracts;

public interface IUserService
{
    IEnumerable<User> GetAllUsers();
    User GetUserById(int id);
    User GetUserByUsername(string username);
    int AddUser(UserDto user);
    int UpdateUser(int userId, UpdateUserDto updateUser);
}
