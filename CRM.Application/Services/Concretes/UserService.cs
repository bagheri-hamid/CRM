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
            _repo.User.Create(new User
            {
                Username = user.Username,
                FullName = user.FullName,
                Role = user.Role,
            });
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
            _repo.User.Update(new User
            {
                Id = user.Id,
                Username = user.Username,
                FullName = updateUser.FullName,
                Role = updateUser.Role,
            });
            _repo.Save();
            return 0;
        }
    }
}
