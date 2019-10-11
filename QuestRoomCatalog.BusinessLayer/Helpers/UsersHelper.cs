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
        public void Create(UsersBO objBO)
        {
            if (objBO.Id == 0)
            {
                Users usersRooms = AutoMapper<UsersBO, Users>.Map(objBO);
                Db.UsersUowRepository.Add(usersRooms);
                Db.Save();
            }
        }

        public void Update(UsersBO objBO)
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

        public IEnumerable<UsersBO> GetAll()
        {
            throw new NotImplementedException();
        }

        public UsersBO Get(int? id)
        {
            throw new NotImplementedException();
        }
    }
}  