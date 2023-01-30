using CRM.Core.Entities;

namespace CRM.Application.Repository.Abstracts;

public interface IContactInfoRepository
{
    ContactInfo GetContactInfoById(int id);
    void AddContactInfo(ContactInfo contactInfo);
}
