using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using ViaVarejo.Domain.Interfaces.Repositories;
using ViaVarejo.Infra.Data.Context;

namespace ViaVarejo.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected Context.ViaVarejoDbContext Db = new Context.ViaVarejoDbContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}