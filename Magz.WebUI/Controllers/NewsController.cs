using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.Controllers;

public class NewsController : Controller
{
    INewsService _newsService;

    public NewsController(INewsService newsService)
    {
        _newsService = newsService;
    }

    // GET
    public IActionResult Index()
    {
        var result = _newsService.TGetList();
        return View(result);
      
    }
}