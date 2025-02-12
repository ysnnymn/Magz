using Magz.CoreLayer.Entities;

namespace Magz.EntityLayer.Concrete;

public class News:IEntity
{
    public int NewsId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public decimal LikeCount { get; set; }
    public DateTime CreatedDate { get; set; }
    public string ImageUrl { get; set; }
    
}