using Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Repositories
{
    public interface IGenericRepository<T>
    {
         void save(T entity);

         void update(T entity);

         void merge(T entity);
    }
}
