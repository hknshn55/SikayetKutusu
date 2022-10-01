using SalmanSikayet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.DataAccess.Abstract
{
    public interface IRepository<T> where T:Entity, new()
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null);
        Task Add(T entity);
    }
}
