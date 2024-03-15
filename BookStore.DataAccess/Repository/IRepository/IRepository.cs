using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        //get all items from db
        IEnumerable<T> GetAll();
        //get an iem from db
        T Get(Expression<Func<T, bool>> filter);
        //create an item or add to db
        void Add(T entity);
        //update an item in db is specific to class
        //void Update(T entity);
        //remove/delete an item from db
        void Delete(T entity);
        //remove list of items from db
        void DeleteRange(IEnumerable<T> entities);
    }
}
