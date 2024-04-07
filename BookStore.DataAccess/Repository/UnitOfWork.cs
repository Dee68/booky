using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private BookStoreContextDb _db;
        public IApplicationUserRepository ApplicationUser { get; set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public ICategoryRepository Category { get; }
        public IProductRepository Product { get; }
        public IProductImageRepository ProductImage { get; private set; }
        public UnitOfWork(BookStoreContextDb db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ProductImage = new ProductImageRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            Company = new CompanyRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
