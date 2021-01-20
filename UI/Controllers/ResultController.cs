using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetResults();
            return View(v);
        }

        // GET: Result/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetResult(id);
            return View(a);
        }

        // GET: Result/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetResult();
            return View(a);
        }

        // POST: Result/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateResult(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Result/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetResult(id);
            return View(a);
        }

        // POST: Result/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditResult(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Result/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Result/Delete/5
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
