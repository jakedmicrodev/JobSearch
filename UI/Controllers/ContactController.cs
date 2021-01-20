using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            List<Contact> v = new JobSearchService().GetContacts();
            return View(v);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            Contact a = new JobSearchService().GetContact(id);
            return View(a);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            Contact a = new JobSearchService().GetContact();
            return View(a);
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(Contact a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateContact(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            Contact a = new JobSearchService().GetContact(id);
            return View(a);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(Contact a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditContact(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
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
