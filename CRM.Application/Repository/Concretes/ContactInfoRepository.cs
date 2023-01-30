using CRM.Application.Repository.Abstracts;
using CRM.Core.Entities;

namespace CRM.Application.Repository.Concretes;

public class ContactInfoRepository : RepositoryBase<ContactInfo>, IContactInfoRepository
{
    public ContactInfoRepository(CrmContext crmContext)
            : base(crmContext)
    {
    }

    public ContactInfo GetContactInfoById(int id)
    {
        return FindByCondition(u => u.Id.Equals(id)).FirstOrDefault();
    }

    public void AddContactInfo(ContactInfo contactInfo)
    {
        Create(contactInfo);
    }
}
