using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ResponseController : Controller
    {
        // GET: Response
        public ActionResult Index()
        {
            List<Response> v = new JobSearchService().GetResponses();
            return View(v);
        }

        // GET: Response/Details/5
        public ActionResult Details(int id)
        {
            Response a = new JobSearchService().GetResponse(id);
            return View(a);
        }

        // GET: Response/Create
        public ActionResult Create()
        {
            Response a = new JobSearchService().GetResponse();
            return View(a);
        }

        // POST: Response/Create
        [HttpPost]
        public ActionResult Create(Response a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateResponse(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Response/Edit/5
        public ActionResult Edit(int id)
        {
            Response a = new JobSearchService().GetResponse(id);
            return View(a);
        }

        // POST: Response/Edit/5
        [HttpPost]
        public ActionResult Edit(Response a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditResponse(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Response/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Response/Delete/5
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
