using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCfromScratch.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index1()
        {
            return View();
        }

        public string Index()
        {
            return "Hello World!";
        }
    }
}
