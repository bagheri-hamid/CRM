using CRM.Application.Repository.Abstracts;
using CRM.Application.Services.Abstracts;
using CRM.Core.Dtos.User;
using CRM.Core.Entities;

namespace CRM.Application.Services.Concretes;

public class UserService : IUserService
{
    private readonly IRepositoryWrapper _repo;

    public UserService(IRepositoryWrapper repo)
    {
        _repo = repo;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _repo.User.GetAll();
    }

    public User GetUserById(int id)
    {
        return _repo.User.GetUserById(id);
    }

    public User GetUserByUsername(string username)
    {
        return _repo.User.GetUserByUsername(username);
    }

    public int AddUser(UserDto user)
    {
        var checkUsername = _repo.User.GetUserByUsername(user.Username);
        if (checkUsername != null)
        {
            return 1;
        }
        else
        {
            User userEntity = UserFactory.GetUser(user.Username, user.FullName, user.Role);
            _repo.User.Create(userEntity);
            _repo.Save();
            return 0;
        }
    }

    public int UpdateUser(int userId,UpdateUserDto updateUser)
    {
        var user = _repo.User.GetUserById(userId);
        if (user is null)
        {
            return 1;
        }
        else
        {
            User updatedUser = UserFactory.GetUser(user.Id , user.Username, updateUser.FullName, updateUser.Role);
            _repo.User.Update(updatedUser);
            _repo.Save();
            return 0;
        }
    }
}
