using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class User
    {
       public int Id { get; set; }
        public int GroupId { get; set; }
        public string Login { get; set; }
        public User(int id, int GroupID, string login)
        {
            Id = id;
            Login = login;
            GroupId = GroupID;
        }
    }
}
