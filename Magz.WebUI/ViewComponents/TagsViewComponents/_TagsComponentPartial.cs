using Magz.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebUI.ViewComponents.TagsViewComponents;

public class _TagsComponentPartial:ViewComponent
{
    ITagService _tagService;

    public _TagsComponentPartial(ITagService tagService)
    {
        _tagService = tagService;
    }

    public IViewComponentResult Invoke()
    {
        var result = _tagService.TGetList();
        return View(result.Data);
    }
    
}