using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.AuthorViewComponents;

public class _PopularAuthorComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}