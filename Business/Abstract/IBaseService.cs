using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBaseService<T>
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
