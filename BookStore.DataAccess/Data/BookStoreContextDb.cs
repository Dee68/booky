using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Data
{
    public class BookStoreContextDb:DbContext
    {
        public BookStoreContextDb(DbContextOptions<BookStoreContextDb> options) :base(options)
        {
            
        }
        public virtual DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "History", DisplayOrder = 1},
                new Category { Id = 2, Name = "Programming", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Mathematics", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Action", DisplayOrder = 4 });
        }
    }
}
