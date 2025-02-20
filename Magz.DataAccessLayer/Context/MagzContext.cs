using Magz.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Magz.DataAccessLayer.Context
{
    public class MagzContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=MagzDb;User ID=SA;Password=Yasinyaman.43;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // News ve Category arasındaki ilişkiyi belirtiyoruz
            modelBuilder.Entity<News>()
                .HasOne(n => n.Category)
                .WithMany(c => c.News)
                .HasForeignKey(n => n.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // Kategori silindiğinde haberler de silinir.

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}