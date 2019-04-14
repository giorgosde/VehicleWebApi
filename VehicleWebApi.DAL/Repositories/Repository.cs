using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleWebApi.DAL.Context;
using VehicleWebApi.DAL.Entities;

namespace VehicleWebApi.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity, IEntity
    {
        protected readonly VehicleContext _context;

        protected Repository(VehicleContext context)
        {
            this._context = context;
        }

        public IQueryable<T> GetAll()
        {
            return this._context.Set<T>().AsQueryable();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>()
                        .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<int> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> Update(int id, T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
