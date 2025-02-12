using Magz.CoreLayer.Entities;

namespace Magz.EntityLayer.Concrete;

public class Category:IEntity
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    List<News> NewsList { get; set; }
    
}