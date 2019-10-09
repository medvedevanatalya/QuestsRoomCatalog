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
        public void Create(QuestsRoomsBO bo)
        {
            if (bo.Id == 0)
            {
                QuestsRooms questsRooms = AutoMapper<QuestsRoomsBO, QuestsRooms>.Map(bo);
                Db.QuestsRoomsUowRepository.Add(questsRooms);
                Db.Save();
            }
        }
    }
}
