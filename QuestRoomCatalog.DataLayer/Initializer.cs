using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.DataLayer
{
    public class Initializer : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 context)
        {
            List<Roles> roles = new List<Roles>();
            roles.Add(new Roles { Id = 1, RoleName = "admin" });
            roles.Add(new Roles { Id = 2, RoleName = "user" });
            context.Roles.AddRange(roles);

            List<Users> users = new List<Users>();
            users.Add(new Users { Id = 1, RoleId = 1, UserName = "Administrator" });
            users.Add(new Users { Id = 2, RoleId = 2, UserName = "User" });
            context.Users.AddRange(users);

            base.Seed(context);
        }
    }
}
