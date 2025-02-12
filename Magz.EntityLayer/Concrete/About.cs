using Magz.CoreLayer.Entities;

namespace Magz.EntityLayer.Concrete;

public class About:IEntity
{
    public int AboutId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    
}