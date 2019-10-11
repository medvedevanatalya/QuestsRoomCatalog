using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.DataLayer.UnitOfWork;

namespace QuestRoomCatalog.BusinessLayer.Helpers
{
    public interface ICrud<T> where T : class
    {          
        void Create(T objBO);
        void Update(T objBO);
        void Delete(int id);
        void Save();
        IEnumerable<T> GetAll();
        T Get(int? id);  
    }
}
