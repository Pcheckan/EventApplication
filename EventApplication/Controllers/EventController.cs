using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventApplication.Controllers
{
    public class EventController : Controller
    {
        public IActionResult EventRecomended()
        {
            return View();
        }

        public IActionResult EventSearch()
        {
            return View();
        }
    }
}
