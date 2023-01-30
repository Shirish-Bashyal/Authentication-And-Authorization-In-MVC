using Authentication_And_Authorization_In_MVC.Data;
using Authentication_And_Authorization_In_MVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Authentication_And_Authorization_In_MVC.Repositories;

namespace Authentication_And_Authorization_In_MVC.Controllers
{
    public class Register : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<UserDetail, int> registerRepository;

        public Register(IRepository<UserDetail,int> registerRepository)
        {
            this.registerRepository = registerRepository;
            //_context = context;
        }



        public IActionResult Index()
        {
            return View();
        }
       
        
        public ActionResult CreateProfile()
        {
            return View();

        }



        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult CreateProfile(UserDetail user)
        {
            //var test = ModelState.IsValid;
            //if (ModelState.IsValid)
            //{
            //    _context.tbl_UserDetails.Add(user);
            //    _context.SaveChanges();



            //}
            var test = ModelState.IsValid;
            if (ModelState.IsValid)
            {
                registerRepository.Insert(user);
                registerRepository.Save();
                
            }


                return RedirectToAction(actionName: "signin", controllerName: "register");

        }


        [HttpGet]
        public IActionResult signin()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult signin(UserDetail user1)
        {
            var status=_context.tbl_UserDetails.Where(u=>u.Email==user1.Email && u.Password==user1.Password).FirstOrDefault();
            if (status == null)
            {
                ViewBag.LoginStatus = 0;
                return View();

            }

            else
            {
                return RedirectToAction("Index", "Home");
                
            }
        }























    }
}
