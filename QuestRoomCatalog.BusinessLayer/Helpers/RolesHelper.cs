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

        public void Create(RolesBO objBO)
        {
            if (objBO.Id == 0)
            {
                Roles rolesRooms = AutoMapper<RolesBO, Roles>.Map(objBO);
                Db.RolesUowRepository.Add(rolesRooms);
                Db.Save();
            }
        }

        public void Update(RolesBO objBO)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            Db.Save();   
        }

        public IEnumerable<RolesBO> GetAll()
        {
            throw new NotImplementedException();
        }

        public RolesBO Get(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
