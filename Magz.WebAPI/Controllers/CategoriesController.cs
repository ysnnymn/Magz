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
           var result= _categoryService.TGetList();
           return Ok(result);
            
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
           var result= _categoryService.TAdd(category);
            return Ok(result.Message);
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
           var result= _categoryService.TUpdate(category);
            return Ok(result.Message);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(Category category)
        {
           var result= _categoryService.TDelete(category);
            return Ok(result.Message);
        }
        
        
    }
}
