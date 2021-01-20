using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetLocations();
            return View(v);
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetLocation(id);
            return View(a);
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetLocation();
            return View(a);
        }

        // POST: Location/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateLocation(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetLocation(id);
            return View(a);
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditLocation(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
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
