using Magz.BusinessLayer.Abstract;
using Magz.EntityLayer.Concrete;
using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
           var value= _categoryService.TGetList();
           return Ok(value);
            
        }

        [HttpGet("id")]
        public IActionResult CategoryDetail(int id)
        {
            var result = _categoryService.TGetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.TAdd(category);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteCategory(Category category)
        {
            _categoryService.TDelete(category);
            return Ok();
        }
        
        
    }
}
