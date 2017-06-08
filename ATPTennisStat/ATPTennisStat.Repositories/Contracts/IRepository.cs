﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ATPTennisStat.Repositories.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);

        IEnumerable<TEntity> GetAll(out DbSet dbSet);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void Remove(TEntity entity);
    }
}
