using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Domain;
using WebApplication1.Infrastructure;
using WebApplication1.Services.DTO;

namespace WebApplication1.Services
{
    public class FactionServices
    {
        internal FactionRepo _repo;

        public FactionServices() {
            _repo = new FactionRepo(AppDbContext.Create());
        }

        public Faction GetFaction(int id)
        {
            var query = _repo.Get(id);
            return new Faction((from f in query
                                select new FactionDTO()
                                {
                                    Id = f.Id,
                                    Active = f.Active,
                                    Name = f.Name
                                }).FirstOrDefault());
        }

        public IEnumerable<Faction> EnumerateAll() { return _repo.Enumerate(); }
    }
}