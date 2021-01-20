using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class PositionTypeController : Controller
    {
        // GET: PositionType
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetPositionTypes();
            return View(v);
        }

        // GET: PositionType/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetPositionType(id);
            return View(a);
        }

        // GET: PositionType/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetPositionType();
            return View(a);
        }

        // POST: PositionType/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreatePositionType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PositionType/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetPositionType(id);
            return View(a);
        }

        // POST: PositionType/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditPositionType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PositionType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PositionType/Delete/5
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
