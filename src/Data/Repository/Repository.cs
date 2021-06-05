using Business.Core.Interfaces;
using Business.Core.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly MeuDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(MeuDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }
        public virtual async Task Adicionar(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
                await SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public Task Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }     

        public virtual async Task<TEntity> ObterPorId(Guid Id)
        {
            return await DbSet.FindAsync(Id);
        }

        public Task<List<TEntity>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task<int> Remover(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
