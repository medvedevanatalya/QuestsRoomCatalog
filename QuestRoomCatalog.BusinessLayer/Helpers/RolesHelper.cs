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
    public class RolesHelper : ICrud<RolesBO>
    {
        UnitOfWork Db { get; set; }
        public RolesHelper(UnitOfWork uow)
        {
            Db = uow;
        }

        public void Create(RolesBO bo)
        {
            if (bo.Id == 0)
            {
                Roles rolesRooms = AutoMapper<RolesBO, Roles>.Map(bo);
                Db.RolesUowRepository.Add(rolesRooms);
                Db.Save();
            }
        }
    }
}
