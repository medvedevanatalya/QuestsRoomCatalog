using Ninject.Modules;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.BusinessLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Helpers
{
    public class NinjectHelper: NinjectModule
    {
        public override void Load()
        {
            Bind<ICrud<QuestsLogosBO>>().To<QuestLogosHelper>();
        }
    }
}