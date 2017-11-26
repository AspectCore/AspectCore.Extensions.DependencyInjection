using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Sample.Controllers
{
    public class HomeController : Controller
    {
        public virtual IActionResult Index()
        {
            return View();
        }

        public virtual IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public virtual IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public virtual IActionResult Error()
        {
            return View();
        }
    }
}
