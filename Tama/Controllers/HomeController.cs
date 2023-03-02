using Microsoft.AspNetCore.Mvc;
using Tama.Models;
using System.Collections;

namespace Tama.Controllers
{

  public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}