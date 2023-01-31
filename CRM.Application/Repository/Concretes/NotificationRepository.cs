using CRM.Application.Repository.Abstracts;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Concretes
{
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(CrmContext crmContext)
            : base(crmContext)
        {
        }

        public IEnumerable<Notification> GetAll()
        {
            return FindAll().ToList();
        }
        public void CreateNotification(Notification notif)
        {
            Create(notif);
        }
    }
}
