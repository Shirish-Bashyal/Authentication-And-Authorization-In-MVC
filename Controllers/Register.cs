using Microsoft.AspNetCore.Mvc;

namespace Authentication_And_Authorization_In_MVC.Controllers
{
    public class Register : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
