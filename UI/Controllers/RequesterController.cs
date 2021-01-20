using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class RequesterController : Controller
    {
        // GET: Requester
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetRequesters();
            return View(v);
        }

        // GET: Requester/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetRequester(id);
            return View(a);
        }

        // GET: Requester/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetRequester();
            return View(a);
        }

        // POST: Requester/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateRequester(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Requester/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetLocation(id);
            return View(a);
        }

        // POST: Requester/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditRequester(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Requester/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Requester/Delete/5
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
