using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public UserInfo(int userid, string name, int age, double salary)
        {
            Age = age;
            Name = name;
            Salary = salary;
            UserId = userid;
        }
    }
}
