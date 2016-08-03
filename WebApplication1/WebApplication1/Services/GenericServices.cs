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

        public void Update(T alteredEntity)
        {
            _repo.Update(alteredEntity);
            _repo.SaveChanges();
        }

        public void Add(T newEntity)
        {
            _repo.Add(newEntity);
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
            _repo.SaveChanges();
        }

        public void Delete(T removeEntity)
        {
            _repo.Delete(removeEntity);
            _repo.SaveChanges();
        }

        public List<T> List()
        {
            return _repo.List();
        }

        public IEnumerable<T> Enumerate()
        {
            return _repo.Enumerate();
        }
    }
}