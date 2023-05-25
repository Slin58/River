using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using River.Data.Models.Domain;
using River.Services.IService;
using River.Services.Service;

namespace River.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        public UserController()
        {
            userService = new UserService();
        }
        public ActionResult GetUsers()
        {
            return View(userService.GetUsers());
        }
        public ActionResult GetUser(string id)
        {
            return View(userService.GetUser(id));
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(string id)
        {
            User user = userService.GetUser(id);
            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user, IFormCollection collection)
        {
            try
            {
                userService.Edit(user);
                return RedirectToAction("GetUser", "User", new { id = user.Id });
            }
            catch
            {
                throw new Exception("Scheiße"); //todo
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
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
