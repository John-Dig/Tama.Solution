using Microsoft.AspNetCore.Mvc;
using Tama.Models;
using System.Collections.Generic;

namespace Tama.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }
  }
}
