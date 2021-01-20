using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class PositionController : Controller
    {
        // GET: Position
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetPositions();
            return View(v);
        }

        // GET: Position/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetPosition(id);
            return View(a);
        }

        // GET: Position/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetPosition();
            return View(a);
        }

        // POST: Position/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreatePosition(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Position/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetPosition(id);
            return View(a);
        }

        // POST: Position/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditPosition(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Position/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Position/Delete/5
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
