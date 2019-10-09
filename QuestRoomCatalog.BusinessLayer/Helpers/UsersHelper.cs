using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.BusinessLayer.Helpers
{
    public class UsersHelper : ICrud<UsersBO>
    {
        UnitOfWork Db { get; set; }
        public UsersHelper(UnitOfWork uow)
        {
            Db = uow;
        }
        public void Create(UsersBO bo)
        {
            if (bo.Id == 0)
            {
                Users usersRooms = AutoMapper<UsersBO, Users>.Map(bo);
                Db.UsersUowRepository.Add(usersRooms);
                Db.Save();
            }
        }
    }
}  