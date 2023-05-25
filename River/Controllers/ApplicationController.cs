using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using River.Data.Models.Domain;
using River.Services.Models;
using River.Services.Service;

namespace River.Controllers
{
    public class ApplicationController : Controller
    {
        ApplicationService applicationService;
        public ApplicationController() { 
            applicationService = new ApplicationService();
        }

        public ActionResult GetApplication(int id)
        {
            return View(applicationService.GetApplication(id));
        }

        // GET: ApplicationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApplicationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult AddApplication()
        {

            return View();
            //return View(applicationService.GetApplication(Id));
        }

        // POST: ApplicationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddApplication(ApplicationUniversity applicationUniversity, IFormCollection collection)
        {
            applicationUniversity = new ApplicationUniversity();
            Application application = new Application();
            application.Id = applicationUniversity.Id;
            application.CourseId = applicationUniversity.CourseId;
            application.Statement = applicationUniversity.Statement;
            application.TeacherContact = applicationUniversity.TeacherContact;
            application.TeacherReference = applicationUniversity.TeacherReference;
            application.Offer = applicationUniversity.Offer;
            application.Firm = applicationUniversity.Firm;


            try
            {
                string userId = HttpContext.Session.GetString("userId");
                applicationService.AddApplication(application, userId, applicationUniversity.UniversityId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
