using Common.OrderBy;
using Domain_Layer.Repository_interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Repository
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SocialMediaContext context;

        public BaseRepository(SocialMediaContext context)
        {
            this.context = context;
        }
        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
            return entities;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await context.Set<T>().AddRangeAsync(entities);
            return entities;
        }

        public void Attach(T entity)
        {
            context.Set<T>().Attach(entity);
        }

        public void AttachRange(IEnumerable<T> entities)
        {
            context.Set<T>().AttachRange(entities);
        }

        public int Count()
        {
            return context.Set<T>().Count();
        }

        public int Count(Expression<Func<T, bool>> criteria)
        {
            return context.Set<T>().Count(criteria);
        }

        public async Task<int> CountAsync()
        {
            return await context.Set<T>().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
        {
            return await context.Set<T>().CountAsync(criteria);
        }

        public void Delete(T entity)
        {
            context.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            context.RemoveRange(entities);
        }

        public T Find(Expression<Func<T, bool>> criteria, string[] includes = null)
        {
            var query =  context.Set<T>().Where(criteria);
            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null)
        {
            var query = context.Set<T>().Where(criteria);
            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);
            return query.ToList();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, int take, int skip)
        {
           return context.Set<T>().Where(criteria).Skip(skip).Take(take).ToList();
           
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, int? take, int? skip, Expression<Func<T, object>> orderBy = null, string orderByDirection = "ASC")
        {
            var query = context.Set<T>().Where(criteria);
            if(take.HasValue)
                query = query.Take(take.Value);
            if(skip.HasValue)
                query = query.Skip(skip.Value);
            if(orderBy != null)
            {
                if(orderByDirection == OrderBy.Ascending)
                    query = query.OrderBy(orderBy);
                else
                    query = query.OrderByDescending(orderBy);   
            }
            return query.ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[] includes = null)
        {
            var query =  context.Set<T>().Where(criteria);
            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take)
        {
            return await context.Set<T>().Where(criteria).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int? skip, int? take, Expression<Func<T, object>> orderBy = null, string orderByDirection = "ASC")
        {
            var query = context.Set<T>().Where(criteria);
            if (take.HasValue)
                query = query.Take(take.Value);
            if (skip.HasValue)
                query = query.Skip(skip.Value);
            if (orderBy != null)
            {
                if (orderByDirection == OrderBy.Ascending)
                    query = query.OrderBy(orderBy);
                else
                    query = query.OrderByDescending(orderBy);
            }
            return await query.ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null)
        {
            var query =  context.Set<T>().Where(criteria);
            if(includes != null)
                foreach (var include in includes)
                    query = query.Include(include);
            return await query.FirstOrDefaultAsync() ;

        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public T Update(T entity)
        {
            context.Update(entity);
            return entity;
        }
    }
}
