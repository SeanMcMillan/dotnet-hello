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
