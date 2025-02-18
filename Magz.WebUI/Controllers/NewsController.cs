using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.Controllers;

public class NewsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}