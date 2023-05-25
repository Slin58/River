using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using River.Data;
using River.Services.Service;

namespace River.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext context;
        UserService userService;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AdminController(SignInManager<IdentityUser> signInManager) {
            context = new ApplicationDbContext();
            _signInManager = signInManager;
            userService = new UserService();
        }

        public ActionResult GetUsers()
        {
            return View(context.Users.ToList());
        }
        public ActionResult GetUser(string id)
        {
            return View(userService.GetUser(id));
        }
        public ActionResult GetRoles()
        {
            return View(context.Roles.ToList());
        }

        public ActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddRole(IFormCollection collection)
        {
            IdentityRole role = new IdentityRole();
            role.Name = collection["RoleName"].ToString();
            role.NormalizedName = collection["RoleName"]
                .ToString().ToUpper();
            context.Roles.Add(role);
            context.SaveChanges();
            return RedirectToAction("GetRoles");
        }

        public ActionResult AddUserToRole()
        {
            FillInDropDowns();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddUserToRole(string userName, string roleName)
        {
            IdentityUser user = _signInManager.UserManager.FindByNameAsync(userName).Result;
            await _signInManager.UserManager.AddToRoleAsync(user, roleName);
            FillInDropDowns();
            return RedirectToAction("AddUserToRole");
        }
        public ActionResult RemoveUserFromRole()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveUserFromRole(string userName, string roleName)
        {
            return View();
        }

        [Authorize]
        public ActionResult GetRolesForUser() {
            return View();
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetRolesForUser(string userName)
        {
            return View();
        }
        void FillInDropDowns()
        {
            //Prepare DropDown for Users
            var userList = context.Users.OrderBy(
                u => u.UserName).ToList().Select(
                    uu => new SelectListItem
                    {
                        Value = uu.UserName.ToString(),
                        Text = uu.UserName
                    }
                ).ToList();
            ViewData["Users"] = userList;
            //Prepare DropDown for Roles
            var roleList = context.Roles.OrderBy(
                r => r.Name).ToList().Select
                (
                    rr => new SelectListItem
                    {
                        Value = rr.Name.ToString(),
                        Text = rr.Name
                    }
                ).ToList();
            ViewData["Roles"] = roleList;
        }



        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
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

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
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

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
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
