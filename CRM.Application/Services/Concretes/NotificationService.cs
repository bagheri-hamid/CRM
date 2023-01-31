using CRM.Application.Repository.Abstracts;
using CRM.Application.Services.Abstracts;
using CRM.Core.Entities;
using CRM.Dtos;

namespace CRM.Application.Services.Concretes;

public class NotificationService : INotificationService
{
    private readonly IRepositoryWrapper _repo;

    public NotificationService(IRepositoryWrapper repo)
    {
        _repo = repo;
    }

    public IEnumerable<Notification> GetNotfications()
    {
        return _repo.Notification.GetAll();
    }

    public int CreateNotification(NotificationDto notifDto)
    {
        var user = _repo.User.GetUserById(notifDto.RecipientId);
        if (user is null)
            return 1;

        var notif = new Notification(notifDto.Type , notifDto.Message ,notifDto.RecipientId);
        _repo.Notification.CreateNotification(notif);
        _repo.Save();
        return 0;
    }
}
