using System;
using System.Collections.Generic;

namespace CRM.Core.Entities
{
    public class UserFactory
    {
        public static User GetUser(string username, string fullName, int role)
        {
            switch (role)
            {
                case 1:
                    return new Manager(username, fullName);
                case 0:
                    return new TeamMember(username, fullName);
                default:
                    throw new Exception("Invalid role provided.");
            }
        }
        public static User GetUser(int id, string username, string fullName, int role)
        {
            switch (role)
            {
                case 1:
                    return new Manager(id, username, fullName);
                case 0:
                    return new TeamMember(id, username, fullName);
                default:
                    throw new Exception("Invalid role provided.");
            }
        }
    }

}
