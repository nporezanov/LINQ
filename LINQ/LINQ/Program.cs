
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Порезанов Николай. Д.З. №4.
/*Создайте 4 сущности: User, UserInfo, Role, Group
User
int Id !
int GroupId
string Login
--------------
UserInfo
int UserId
string Name
int Age
double Salary
____________________
Group
int Id !
int RoleId
string Name
-----------------
Role
int Id !
string Name
Напишите следующие запросы
a. Выведите все группы и количество пользователей в этих группах
b. Выведите все группы и количество пользователей в этих группах, возраст которых больше 25
c. Выведите все группы и количество пользователей в этих группах, возраст которых больше 25 и роль которых, например, администратор
d. Выведите все группы, при этом в каждой группе нужно сгруппировать всех пользователей по ролям*/

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Role[] rols = {new Role(1,"boss"),
                new Role(2,"manager"),
                new Role(3,"support"),
                new Role(4,"salesman")
            };
            Group[] groups = { new Group(1,1,"Employer"),
            new Group(2,3,"Admin"),
            new Group(3,2,"employee")
           
            };
            User[] users = { new User(1, 1, "Kuz"),
                new User(2,2,"IvanovR"),
                new User(3,2,"Bas"),
                new User(4,3,"Levin"),
                new User(5,3,"Masl"),
                new User(6,3,"Took"),
                new User(7,3,"Griva"),
            };
            UserInfo[] infos = { new UserInfo(1, "D.G.Kuznec", 38, 125623),
                new UserInfo(2, "R.O. Ivanov", 36, 72042),
                new UserInfo(3, "D.M. Baskoff", 29, 68300),
                new UserInfo(4, "I.I. Levin", 23, 47000),
                new UserInfo(5, "V.I. Maslinova", 40, 65000),
                new UserInfo(6, "G.H.Tukin", 24, 43000),
                new UserInfo(7, "L.L.Grivanskiy", 35, 39751)
            };
 
            #region Выведите все группы и количество пользователей в этих группах
            var a_task = (from user in users
                          join grp in groups on user.GroupId equals grp.Id
                          group grp by grp.Name into usergrp
                          select new { CategoryName = usergrp.Key, UserCount = usergrp.Count() }).ToList();
            foreach (var item in a_task)
                Console.WriteLine(item.ToString());
            #endregion
            #region b.-||-, возраст которых больше 25

            var b_task = (from user in users
                          join grp in groups
                          on user.GroupId equals grp.Id
                          join inf in infos
                          on user.Id equals inf.UserId
                          where inf.Age>25
                          group grp by grp.Name into usergrp
                          select new { CategoryName = usergrp.Key, UserCount = usergrp.Count() }).ToList();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var itemB in b_task)                
                Console.WriteLine(itemB.ToString());
            #endregion
            var Eusers = from usr in users
                         select usr.Login;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("вывод списка всех пользователей по логинам:");
            foreach (string s in Eusers) Console.WriteLine(" " + s);

            var Einfo = from inf in infos
                        where inf.Age > 25
                        orderby inf.Age descending
                        select inf.Age;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("список тех кому больше 25 лет:");
            foreach (int s in Einfo) Console.WriteLine(" " + s);

            var Erole = from cust in rols
                        where cust.Name == "support"
                        orderby cust.Name
                        select cust.Name;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (string s in Erole) Console.WriteLine(" " + s);

            Console.ReadKey();

        }
    }
}
