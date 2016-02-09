using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Consultancy.Application.Repository
{
    public interface IGenericRepository<T> where T:class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(int id);
        IEnumerable<T>GetAll();
        T GetById(int id);
        List<T> Search(string param);
    }
}
