using Consultancy.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Consultancy.Application.Context;
using System.Data.Entity;

namespace Consultancy.Application.Repository
{
    public interface IConsultancyRepository : IGenericRepository<Consultancies>
    {
        
    }
    public class ConsultancyRepository : IConsultancyRepository
    {
        private AbcDbContext db = new AbcDbContext();
        public void Delete(int id)
        {
            Consultancies c = db.Consultancies.Find(id);
            db.Consultancies.Remove(c);
        }

        public IEnumerable<Consultancies> GetAll()
        {
            return db.Consultancies.ToList();
        }

        public Consultancies GetById(int id)
        {
            return db.Consultancies.Find(id);
        }

        public void Insert(Consultancies t)
        {
             db.Consultancies.Add(t);
        }

       

        public List<Consultancies> Search(string param)
        {
            throw new NotImplementedException();
        }

        public void Update(Consultancies t)
        {
            db.Entry(t).State = EntityState.Modified;
        }
    }
}