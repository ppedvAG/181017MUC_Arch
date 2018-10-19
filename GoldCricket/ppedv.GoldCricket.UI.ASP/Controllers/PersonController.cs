using ppedv.GoldCricket.Data.EF;
using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ppedv.GoldCricket.UI.ASP.Controllers
{
    public class PersonController : Controller
    {
        public PersonController()
        {
            core = new Core(new EFUnitOfWork());
        }
        private Core core;

        // GET: Person
        public ActionResult Index()
        {
            return View(core.UnitOfWork.PersonRepository.GetAll());
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View(core.UnitOfWork.PersonRepository.GetByID(id));
        }

        public ActionResult GPWOA()
        {
            return View(core.FindPersonWithOldestRunningApplication());
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View(new Person { Vorname = "Max", Nachname = "Mustermann" });
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person newPerson)
        {
            try
            {
                core.UnitOfWork.PersonRepository.Add(newPerson);
                core.UnitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View(core.UnitOfWork.PersonRepository.GetByID(id));
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Person editedPerson)
        {
            try
            {
                core.UnitOfWork.PersonRepository.Update(editedPerson);
                core.UnitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View(core.UnitOfWork.PersonRepository.GetByID(id));
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var bitteLöschMich = core.UnitOfWork.PersonRepository.GetByID(id);
                if (bitteLöschMich != null)
                {
                    core.UnitOfWork.PersonRepository.Delete(bitteLöschMich);
                    core.UnitOfWork.Save();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
