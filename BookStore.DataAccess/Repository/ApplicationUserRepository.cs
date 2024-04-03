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
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly BookStoreContextDb _db;
        public ApplicationUserRepository(BookStoreContextDb db) : base(db)
        {
            _db = db;
        }
        void IApplicationUserRepository.Update(ApplicationUser user)
        {
            _db.ApplicationUsers.Update(user);
        }
    }
}
