using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain.Interfaces;
using WebApplication1.Infrastructure;

namespace WebApplication1.Services
{
    public class GenericServices<T> where T: class, IDbEntity, IActivatable
    {
        internal GenericRepository<T> _repo;

        public T Get(int id)
        {
            var query = _repo.Get(id);
            return (from t in query select t).FirstOrDefault();
        }

        public void Update(T alteredentity)
        {
            _repo.Update(alteredentity);
            _repo.SaveChanges();
        }

        public void Add(T newentity)
        {
            _repo.Add(newentity);
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
            _repo.SaveChanges();
        }

        public IEnumerable<T> Enumerate() { return _repo.Enumerate(); }
    }
}