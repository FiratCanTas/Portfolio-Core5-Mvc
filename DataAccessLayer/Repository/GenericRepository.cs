using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        //Generic Repo class üzerinden calısır o yüzden yine T alır diye belirtip ınterface inden kalıtım alıyoruz.
        public void Delete(T t)
        {
            using var _db = new Context();
            _db.Remove(t);
            _db.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var _db = new Context();
           return _db.Set<T>().Find(id); //Gelen T değerini Set edip find la 
        }

        public List<T> GetList()
        {
            using var _db = new Context();
            return _db.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var _db = new Context();
            _db.Add(t);
            _db.SaveChanges();
        }

        public void Update(T t)
        {
            using var _db = new Context();
            _db.Update(t);
            _db.SaveChanges();
        }
    }
}
