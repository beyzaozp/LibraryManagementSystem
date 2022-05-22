using LibraryManagementSystem.Entities.Interfaces;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace LibraryManagementSystem.Business.Services.Base
{
    public interface IBaseService<TEntity, TValidator> : IDisposable where TEntity : class, IEntity, new() where TValidator : IValidator, new()
    {
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);
        void AddorUpdate(TEntity entity);
        void AddorUpdate(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> filter);
        void EntityStateChange(Expression<Func<TEntity, bool>> filter, EntityState state);
        void EntityStateChange(TEntity entity, EntityState state);
        void EntityStateChange(IEnumerable<TEntity> entities, EntityState state);

        TEntity get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);

        bool Exist(Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, Object>>[] includes);

        IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes);
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes);

        void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);

        bool HasChanges();

        BindingList<TEntity> BindingList();
    }
}
