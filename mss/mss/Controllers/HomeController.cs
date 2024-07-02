using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class HomeController : Controller
    {
       

        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            return View();
        }

       

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Tickets()
        {
            return View();
        }
    }
}
