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
    public class RatingHelper : ICrud<RatingBO>
    {
        UnitOfWork Db { get; set; }
        public RatingHelper(UnitOfWork uow)
        {
            Db = uow;
        }

        public void Create(RatingBO objBO)
        {
            if (objBO.Id == 0)
            {
                Rating ratingRooms = AutoMapper<RatingBO, Rating>.Map(objBO);
                Db.RatingUowRepository.Add(ratingRooms);
                Db.Save();
            }
        }

        public void Update(RatingBO objBO)
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
        public IEnumerable<RatingBO>  GetAll()
        {
            throw new NotImplementedException();
        }

        public RatingBO Get(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
