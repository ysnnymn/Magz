

using Magz.CoreLayer.Entities;

namespace Magz.EntityLayer.Concrete;

public class Author:IEntity
{
    public int AuthorId { get; set; }
    public string NameSurname { get; set; }
    public string ImageUrl { get; set; }
    public string Descripiton { get; set; }
    public string AuthorJob { get; set; }
    public List<SocialMedia> SocialMedias { get; set; }
    
    
}