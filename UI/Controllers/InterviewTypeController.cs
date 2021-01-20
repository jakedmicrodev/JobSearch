using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class InterviewTypeController : Controller
    {
        // GET: InterviewType
        public ActionResult Index()
        {
            List<IdName> v = new JobSearchService().GetInterviewTypes();
            return View(v);
        }

        // GET: InterviewType/Details/5
        public ActionResult Details(int id)
        {
            IdName a = new JobSearchService().GetInterviewType(id);
            return View(a);
        }

        // GET: InterviewType/Create
        public ActionResult Create()
        {
            IdName a = new JobSearchService().GetInterviewType();
            return View(a);
        }

        // POST: InterviewType/Create
        [HttpPost]
        public ActionResult Create(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateInterviewType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InterviewType/Edit/5
        public ActionResult Edit(int id)
        {
            IdName a = new JobSearchService().GetInterviewType(id);
            return View(a);
        }

        // POST: InterviewType/Edit/5
        [HttpPost]
        public ActionResult Edit(IdName a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditInterviewType(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InterviewType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InterviewType/Delete/5
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
