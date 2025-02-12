using Magz.CoreLayer.Entities;
using Magz.EntityLayer.Concrete;

public class SocialMedia:IEntity
{
    public int SocialMediaId { get; set; }
    public string SocailMediaName { get; set; }
    public string ImageUrl { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    
}