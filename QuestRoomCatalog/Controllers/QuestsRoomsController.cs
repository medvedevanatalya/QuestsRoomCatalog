using QuestRoomCatalog.BusinessLayer;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.BusinessLayer.Helpers;
using QuestRoomCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomCatalog.Controllers
{
    public class QuestsRoomsController : Controller
    {
        ICrud<QuestsRoomsBO> questRoomsBO;

        public QuestsRoomsController(ICrud<QuestsRoomsBO> questRoomsBO)
        {
            this.questRoomsBO = questRoomsBO;
        }
        // GET: QuestsRooms
        public ActionResult Index()
        {


            return View();
        }

        // GET: QuestsRooms/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestsRooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestsRooms/Create
        [HttpPost]
        public ActionResult Create(QuestsRoomsViewModel collection)
        {
            try
            {
                var bo = AutoMapper<QuestsRoomsViewModel, QuestsRoomsBO>
                    .Map(collection);
                questRoomsBO.Create(bo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestsRooms/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestsRooms/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestsRooms/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestsRooms/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
