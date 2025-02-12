using Magz.CoreLayer.Entities;

namespace Magz.EntityLayer.Concrete;

public class Contact:IEntity
{
    public int ContactId { get; set; }
    public string NameSurname { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    
    
}