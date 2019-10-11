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
    public class QuestRoomsHelper : ICrud<QuestsRoomsBO>
    {
        UnitOfWork Db { get; set; }
        public QuestRoomsHelper(UnitOfWork uow)
        {
            Db = uow;
        }
        public void Create(QuestsRoomsBO objBO)
        {
            if (objBO.Id == 0)
            {
                QuestsRooms questsRooms = AutoMapper<QuestsRoomsBO, QuestsRooms>.Map(objBO);
                Db.QuestsRoomsUowRepository.Add(questsRooms);
                Db.Save();
            }
        }

        public void Update(QuestsRoomsBO objBO)
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

        public IEnumerable<QuestsRoomsBO> GetAll()
        {
            throw new NotImplementedException();
        }

        public QuestsRoomsBO Get(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
