using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.Controllers;

public class TagsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}