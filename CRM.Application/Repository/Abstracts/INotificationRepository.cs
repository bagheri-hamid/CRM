using CRM.Application.Repository.Concretes;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Abstracts
{
    public interface INotificationRepository : IRepositoryBase<Notification>
    {
        IEnumerable<Notification> GetAll();
        void CreateNotification(Notification notif);
    }
}
