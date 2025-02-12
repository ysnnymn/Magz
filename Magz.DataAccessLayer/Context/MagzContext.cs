using Magz.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Magz.DataAccessLayer.Context;

public class MagzContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog =MagzDb; User ID = SA; Password = Yasinyaman.43; Connect Timeout = 10; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");    
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<SocialMedia> SocialMediae { get; set; }
    public DbSet<Tag> Tags { get; set; }
}