using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.Entities
{
    public class Manager : User
    {
        public Manager(string username, string fullName) : base(username, fullName,1)
        {
        }
        public Manager(int id, string username, string fullName) : base(id, username, fullName, 1)
        {
        }
    }
}
