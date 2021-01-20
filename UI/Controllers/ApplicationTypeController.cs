using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ApplicationTypeController : Controller
    {
        // GET: ApplicationType
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetApplicationTypes();
            return View(v);
        }

        // GET: ApplicationType/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetApplicationType(id);
            return View(a);
        }

        // GET: ApplicationType/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetApplicationType();
            return View(a);
        }

        // POST: ApplicationType/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateApplicationType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationType/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetApplicationType(id);
            return View(a);
        }

        // POST: ApplicationType/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditApplicationType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationType/Delete/5
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
