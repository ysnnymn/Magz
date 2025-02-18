using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.CommentsViewComponents;

public class _LatestCommentsPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}