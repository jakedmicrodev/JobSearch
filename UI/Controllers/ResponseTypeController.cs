using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ResponseTypeController : Controller
    {
        // GET: ResponseType
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetResponseTypes();
            return View(v);
        }

        // GET: ResponseType/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetResponseType(id);
            return View(a);
        }

        // GET: ResponseType/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetResponseType();
            return View(a);
        }

        // POST: ResponseType/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateResponseType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ResponseType/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetResponseType(id);
            return View(a);
        }

        // POST: ResponseType/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditResponseType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ResponseType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResponseType/Delete/5
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
