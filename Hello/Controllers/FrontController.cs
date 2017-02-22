using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers
{
    [Route("/")]
    public class FrontController : Controller
    {
        [HttpGet]
        public IActionResult Front()
        {
            return View();
        }

    }
}
