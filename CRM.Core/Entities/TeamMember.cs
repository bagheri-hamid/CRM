using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.Entities
{
    public class TeamMember : User
    {
        public TeamMember(string username, string fullName) : base(username, fullName,0)
        {
        }
        public TeamMember(int id, string username, string fullName) : base(id, username, fullName, 0)
        {
        }
    }
}
