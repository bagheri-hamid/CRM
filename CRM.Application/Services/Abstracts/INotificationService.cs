using CRM.Core.Entities;
using CRM.Dtos;

namespace CRM.Application.Services.Abstracts;

public interface INotificationService
{
    IEnumerable<Notification> GetNotfications();
    int CreateNotification(NotificationDto notifDton);
}
