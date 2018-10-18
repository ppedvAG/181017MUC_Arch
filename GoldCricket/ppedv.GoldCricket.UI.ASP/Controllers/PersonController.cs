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
            core = new Core(new EFRepository());
        }
        private Core core;

        // GET: Person
        public ActionResult Index()
        {
            return View(core.Repository.GetAll<Person>());
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View(core.Repository.GetByID<Person>(id));
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
                core.Repository.Add(newPerson);
                core.Repository.Save();

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
            return View(core.Repository.GetByID<Person>(id));
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Person editedPerson)
        {
            try
            {
                core.Repository.Update(editedPerson);
                core.Repository.Save();

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
            return View(core.Repository.GetByID<Person>(id));
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var bitteLöschMich = core.Repository.GetByID<Person>(id);
                if (bitteLöschMich != null)
                {
                    core.Repository.Delete(bitteLöschMich);
                    core.Repository.Save();
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
