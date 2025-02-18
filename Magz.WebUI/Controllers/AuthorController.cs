using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.Controllers;

public class AuthorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}