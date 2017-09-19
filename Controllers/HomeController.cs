using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_2___Bootstrap_MVC_Template___UR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Media()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
