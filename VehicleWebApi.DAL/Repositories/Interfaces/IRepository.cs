using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWebApi.DAL.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task<int> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<int> Delete(int id);
    }
}
