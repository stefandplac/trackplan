using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using trackplan.Models;

namespace trackplan.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            var model = new Word();
            return View(model);
        }

       
    }
}