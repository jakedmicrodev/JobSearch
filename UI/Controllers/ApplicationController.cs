using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            List<Application> v = new JobSearchService().GetApplications();
            return View(v);
        }

        // GET: Application/Details/5
        public ActionResult Details(int id)
        {
            Application a = new JobSearchService().GetApplication(id);
            return View(a);
        }

        // GET: Application/Create
        public ActionResult Create()
        {
            Application a = new JobSearchService().GetApplication();
            return View(a);
        }

        // POST: Application/Create
        [HttpPost]
        public ActionResult Create(Application a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateApplication(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Application/Edit/5
        public ActionResult Edit(int id)
        {
            Application a = new JobSearchService().GetApplication(id);
            return View(a);
        }

        // POST: Application/Edit/5
        [HttpPost]
        public ActionResult Edit(Application a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditApplication(a);

                return RedirectToAction("Search");
            }
            catch
            {
                return View();
            }
        }

        // GET: Application/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Application/Delete/5
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

        public ActionResult Search()
        {
            Application a = new JobSearchService().GetApplication();
            ApplicationSearch app = new ApplicationSearch();

            app.Companies = a.Companies;
            app.Contacts = a.Contacts;
            app.Requesters = a.Requesters;

            return View(app);
        }

        [HttpPost]
        public ActionResult Search(ApplicationSearch s)
        {

            List<Application> l = new JobSearchService().GetApplications(s);
            TempData["Applications"] = l;

            return Redirect("SearchResults");
 
        }

        public ActionResult SearchResults()
        {
            List<Application> v = TempData["Applications"] as List<Application>;
            return View(v);
        }

        public ActionResult CreateInterview(int Id)
        {
            TempData["ApplicationId"] = Id;
            return RedirectToAction("Create", "Interview", new { area = "" });
        }

        [ChildActionOnly]
        public ActionResult Interviews(int applicationId)
        {
            List<Interview> l = new JobSearchService().GetInterviews(applicationId);
            return View(l);
        }

        [ChildActionOnly]
        public ActionResult InterviewDetails(int applicationId)
        {
            List<Interview> l = new JobSearchService().GetInterviews(applicationId);
            if(l.Count > 0)
            {
                return PartialView(l[0]);
            }
            else
            {
                return PartialView(new Interview());
            }
        }

        public ActionResult CreateResponse(int Id)
        {
            TempData["ApplicationId"] = Id;
            return RedirectToAction("Create", "Response", new { area = "" });
        }


        [ChildActionOnly]
        public ActionResult Responses(int applicationId)
        {
            List<Response> l = new JobSearchService().GetResponses(applicationId);
            return View(l);
        }

        [ChildActionOnly]
        public ActionResult ResponseDetails(int applicationId)
        {
            List<Response> l = new JobSearchService().GetResponses(applicationId);
            if (l.Count > 0)
            {
                return PartialView(l[0]);
            }
            else
            {
                return PartialView(new Response());
            }
        }

    }
}
