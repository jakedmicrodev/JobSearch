using Business.Entities;
using Business.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            List<Company> v = new JobSearchService().GetCompanies();
            return View(v);
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            Company a = new JobSearchService().GetCompany(id);
            return View(a);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            Company a = new JobSearchService().GetCompany();
            return View(a);
        }

        // POST: Company/Create
        [HttpPost]
        public ActionResult Create(Company a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.CreateCompany(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            Company a = new JobSearchService().GetCompany(id);
            return View(a);
        }

        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult Edit(Company a)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.EditCompany(a);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            Company a = new JobSearchService().GetCompany(id);
            return View(a);
        }

        // POST: Company/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                JobSearchService m = new JobSearchService();
                m.DeleteCompany(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
