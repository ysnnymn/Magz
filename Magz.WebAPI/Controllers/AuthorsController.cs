using Magz.BusinessLayer.Abstract;
using Magz.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Magz.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]

public class AuthorsController : ControllerBase
{
    IAuthorService _authorService;

    public AuthorsController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet]
    public IActionResult AuthorList()
    {
        var result = _authorService.TGetList();
        return Ok(result.Data);
    }

    [HttpGet("id")]
    public IActionResult GetAuthor(int id)
    {
        var result = _authorService.TGetById(id);
        return Ok(result.Data);
    }

    [HttpPost]
    public IActionResult CreateAuthor(Author author)
    {
        var result = _authorService.TAdd(author);
        
        return  Ok(result.Message);
    }

    [HttpPut]
    public IActionResult UpdateAuthor(Author author)
    {
        var result = _authorService.TUpdate(author);
        return Ok(result.Message);
    }

    [HttpDelete]
    public IActionResult DeleteAuthor(Author author)
    {
        var result = _authorService.TDelete(author);
        return Ok(result.Message);
    }
}