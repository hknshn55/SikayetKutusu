
using Microsoft.EntityFrameworkCore;
using SalmanSikayet.DataAccess.Abstract;
using SalmanSikayet.DataAccess.Concrete.Context;
using SalmanSikayet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.DataAccess.Concrete
{
    public class RepositoryBase<T> : IRepository<T> where T : Entity, new()
    {
        private readonly SalmanSikayetContext _db;
        private DbSet<T> set { get; } 
        public RepositoryBase(SalmanSikayetContext contex)
        {
            _db = contex;
            set = contex.Set<T>();
        }
        public async Task Add(T entity)
        {
            set.Add(entity);
            await _db.SaveChangesAsync();
        }
        public async Task<List<T>> GetAll(Expression<Func<T,bool>> expression = null)
        {
            return expression == null ? await set.ToListAsync() : await set.Where(expression).ToListAsync();
        }

    }
}
