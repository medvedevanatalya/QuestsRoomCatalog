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
    public class QuestLogosHelper : ICrud<QuestsLogosBO>
    {
        UnitOfWork Db { get; set; }

        public QuestLogosHelper(UnitOfWork uow)
        {
            Db = uow;
        }

        public void Create(QuestsLogosBO objBO)
        {
            if (objBO.Id == 0)
            {
                QuestsLogos questLogos = AutoMapper<QuestsLogosBO, QuestsLogos>.Map(objBO);
                Db.QuestsLogosUowRepository.Add(questLogos);
                Db.Save();
            }   
        }

        public void Update(QuestsLogosBO objBO)
        {
            if (objBO.Id != 0)
            {
                QuestsLogos questLogos = AutoMapper<QuestsLogosBO, QuestsLogos>.Map(objBO);
                Db.QuestsLogosUowRepository.Update(questLogos);
                Db.Save();
            }
        }

        public void Delete(QuestsLogosBO objBO)
        {
            if (objBO.Id != 0)
            {
                QuestsLogos questLogos = AutoMapper<QuestsLogosBO, QuestsLogos>.Map(objBO);
                Db.QuestsLogosUowRepository.Delete(objBO.Id);
                Db.Save();
            }
        }

        public void Save()
        {
            Db.Save();        
        }

        public IEnumerable<QuestsLogosBO>  GetAll()
        {
            throw new NotImplementedException();
        }

        public QuestsLogosBO Get(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
