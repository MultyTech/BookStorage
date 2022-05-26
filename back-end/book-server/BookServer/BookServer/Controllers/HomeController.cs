using Microsoft.AspNetCore.Mvc;
using Services.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookServer.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IHomeService)
        {

        }
        public IActionResult Home()
        {
            //returna all books
            return this.View();
        }
    }
}
