using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.Controllers;

public class CommentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}