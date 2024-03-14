using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContextDb:DbContext
    {
        public BookStoreContextDb(DbContextOptions<BookStoreContextDb> options) :base(options)
        {
            
        }
        public virtual DbSet<Category> Categories { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
