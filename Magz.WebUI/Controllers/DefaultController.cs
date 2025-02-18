using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}