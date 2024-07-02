using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mss.Controllers
{
    public class AdminController : Controller // Inherit from Controller class
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
