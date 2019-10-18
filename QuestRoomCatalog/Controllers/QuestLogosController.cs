using QuestRoomCatalog.BusinessLayer;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.BusinessLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomCatalog.Controllers
{
    public class QuestLogosController : Controller
    {
        ICrud<QuestsLogosBO> questLogosBO;



        public QuestLogosController(ICrud<QuestsLogosBO> questLogosBO)
        {
            this.questLogosBO = questLogosBO;
        }
        
        // GET: QuestLogos
        public ActionResult Index()
        {
            //var list = AutoMapper<IEnumerable<QuestsLogosBO>, List<QuestsLogosViewModel>>.Map(questLogosBO.GetAll().ToList());
                //var objBO = AutoMapper<IEnumerable<QuestsLogosBO>,IEnumerable<QuestsLogosViewModel>>.Map(questLogosBO.GetAll());
            //var objBO = AutoMapper<List<QuestsLogosViewModel>, IEnumerable<QuestsLogosBO>>.Map(questLogosBO.GetAll);

            return View();
        }

        // GET: QuestLogos/Details/5
        public ActionResult Details(int id)
        {  
            return View();
        }

        // GET: QuestLogos/Create
        public ActionResult Create()
        {      
            return View();
        }

        // POST: QuestLogos/Create
        [HttpPost]
        public ActionResult Create(QuestsLogosViewModel collection)
        {
            try
            {
                var objBO = AutoMapper<QuestsLogosViewModel, QuestsLogosBO>.Map(collection);
                questLogosBO.Create(objBO);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestLogos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestLogos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, QuestsLogosViewModel collection)
        {
            try
            {
                var objBO = AutoMapper<QuestsLogosViewModel, QuestsLogosBO>.Map(collection);
                questLogosBO.Update(objBO);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestLogos/Delete/5
        public ActionResult Delete(int id)
        { 
            questLogosBO.Delete(id);

            return View();
        }       
    }
}
