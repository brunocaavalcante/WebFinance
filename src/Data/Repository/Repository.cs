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
            DbSet.Add(entity);
            await SaveChanges();
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

        public virtual async Task Remover(TEntity entity)
        {
            DbSet.Remove(entity); //O metodo remove pede um entity por isso estanciamos apenas uma entity passando o id pra ela
            await SaveChanges();
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
