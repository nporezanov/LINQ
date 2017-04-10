using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Подсказка:
 * Реализация списков, в данном случае, не имеет значения.
Добавьте к своим запросам join, т.к. не вся необходимая информация находиться в одной коллекции.
Затем group by для группировки коллекции по указанному вами полю.
var query2 = (from user in users
join grp in groups on user.GroupId equals grp.Id
group grp by grp.Name into usergrp
select new { CategoryName = usergrp.Key, UserCount = usergrp.Count() }).ToList();
        foreach (var item in query2)
            Console.WriteLine(item.ToString());
*/

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
        public override string ToString()
        {
            return $"{Id},\t{RoleId},\t{Name}";
        }
    }
}
