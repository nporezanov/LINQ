using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Group
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public Group(int id, int roleid, string name)
        {
            Id = id;
            RoleId = roleid;
            Name = name;
        }
    }
}
