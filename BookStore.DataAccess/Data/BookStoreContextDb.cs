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
        public virtual DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "History", DisplayOrder = 1},
                new Category { Id = 2, Name = "Programming", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Mathematics", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Action", DisplayOrder = 4 });
            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    Id = 1, Title = "1491:New Revelations of the Americas Before Columbus",
                    Description = "In this groundbreaking work of science, history, and archaeology, Charles C. Mann radically alters our understanding of the Americas before the arrival of Columbus in 1492.",
                    Author = "Charles C. Mann", 
                    ISBN = "98767114J3900", 
                    ListPrice = 16, 
                    Price = 18, 
                    Price50 = 14, 
                    Price100 = 12,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                 new Product
                 {
                     Id = 2,
                     Title = "Men Of Mathematics",
                     Description = "Here is the classic, much-read introduction to the craft and history of mathematics by E.T. Bell, a leading figure in mathematics in America for half a century.",
                     Author = "Eric Temple Bell",
                     ISBN = "9780075549437",
                     ListPrice = 30,
                     Price = 27,
                     Price50 = 25,
                     Price100 = 20,
                     CategoryId = 3,
                     ImageUrl = ""
                 },
                 new Product
                 {
                     Id = 3,
                     Title = "Relativity: The Special and the General Theory",
                     Description = "According to Einstein himself, this book is intended \"to give an exact insight into the theory of Relativity to those readers who, from a general scientific and philosophical point of view, are interested in the theory, but who are not conversant with the mathematical apparatus of theoretical physics.",
                     Author = "Albert Einstein, Nigel Calder",
                     ISBN = "9785375549437",
                     ListPrice = 30,
                     Price = 27,
                     Price50 = 25,
                     Price100 = 20,
                     CategoryId = 3,
                     ImageUrl = ""
                 });
        }
    }
}
