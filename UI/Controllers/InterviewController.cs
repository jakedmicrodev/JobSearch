using Business.Entities;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace UI.Controllers
{
    public class InterviewController : Controller
    {
        // GET: Interview
        public ActionResult Index()
        {
            List<Interview> v = new JobSearchService().GetInterviews();
            return View(v);
        }

        // GET: Interview/Details/5
        public ActionResult Details(int id)
        {
            Interview a = new JobSearchService().GetInterview(id);
            return View(a);
        }

        // GET: Interview/Create
        public ActionResult Create()
        {          
            Interview a = new JobSearchService().GetInterview();
            a.ApplicationId = (int)TempData["ApplicationId"];
            return View(a);
        }

        // POST: Interview/Create
        [HttpPost]
        public ActionResult Create(Interview a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateInterview(a);

                return RedirectToAction("Edit", "Application", new { Id = a.ApplicationId});
            }
            catch(Exception e)
            {

                return View();
            }
        }

        // GET: Interview/Edit/5
        public ActionResult Edit(int id)
        {
            Interview a = new JobSearchService().GetInterview(id);
            return View(a);
        }

        // POST: Interview/Edit/5
        [HttpPost]
        public ActionResult Edit(Interview a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditInterview(a);

                return RedirectToAction("Edit", "Application", new { id = a.ApplicationId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Interview/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Interview/Delete/5
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
