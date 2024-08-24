using Microsoft.AspNetCore.Mvc;

namespace marvel_api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
