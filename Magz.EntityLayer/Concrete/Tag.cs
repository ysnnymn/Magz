using Magz.CoreLayer.Entities;

namespace Magz.EntityLayer.Concrete;

public class Tag:IEntity
{
    public int TagId { get; set; }
    public string TagName { get; set; }
}