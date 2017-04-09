
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
            //Выведите все группы и количество пользователей в этих группах
            // SELECT id_topic, COUNT(id_topic) FROM posts
            // GROUP BY id_topic;
            var Egroups = from grp in groups
                          group grp by grp.Name;
            foreach (IGrouping<int,int,Group> g in Egroups)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine(t.Name);
                Console.WriteLine();
            }


          //  Console.WriteLine("Список групп:");
            
           // foreach (string s in Egroups) Console.WriteLine(" " + s);
            Console.ReadKey();

        }
    }
}
