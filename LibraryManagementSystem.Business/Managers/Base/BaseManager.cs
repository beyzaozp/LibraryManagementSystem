using FluentValidation;
using LibraryManagementSystem.Business.Services.Base;
using LibraryManagementSystem.DataAccess.UnitOfWork;
using LibraryManagementSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Managers.Base
{
    public class BaseManager<TEntity, TValidator> : IBaseService<TEntity, TValidator> where TEntity : class, IEntity, new() where TValidator : IValidator, new()
    {
        private bool disposedValue;
        private IUnitOfWork _uow;

        public BaseManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public virtual void Add(TEntity entity)
        {
            _uow.Dal<TEntity, TValidator>().Add(entity);
        }


        public virtual void Add(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity, TValidator>().Add(entities);
        }

        public virtual void AddorUpdate(TEntity entity)
        {
            _uow.Dal<TEntity, TValidator>().AddorUpdate(entity);
        }

        public virtual void AddorUpdate(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity, TValidator>().AddorUpdate(entities);
        }
        public virtual void Update(TEntity entity)
        {
            _uow.Dal<TEntity, TValidator>().Update(entity);
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity, TValidator>().Update(entities);
        }
        public virtual void Delete(TEntity entity)
        {
            _uow.Dal<TEntity, TValidator>().Delete(entity);
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity, TValidator>().Delete(entities);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _uow.Dal<TEntity, TValidator>().Delete(filter);
        }

        public virtual bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _uow.Dal<TEntity, TValidator>().Exist(filter);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity, TValidator>().get(filter, includes);
        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity, TValidator>().GetList(filter, includes);
        }
        public virtual BindingList<TEntity> BindingList()
        {
            return _uow.Dal<TEntity, TValidator>().BindingList();
        }
        public bool HasChanges()
        {
            return _uow.Dal<TEntity, TValidator>().HasChanges();
        }

        public virtual void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            _uow.Dal<TEntity, TValidator>().Load(filter, includes);
        }

        public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity, TValidator>().Select(filter, selector, includes);
        }

        public virtual IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity, TValidator>().Select(filter, selector, includes);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void EntityStateChange(Expression<Func<TEntity, bool>> filter, EntityState state)
        {
            _uow.Dal<TEntity, TValidator>().EntityStateChange(filter, state);
        }

        public void EntityStateChange(TEntity entity, EntityState state)
        {
            _uow.Dal<TEntity, TValidator>().EntityStateChange(entity, state);
        }

        public void EntityStateChange(IEnumerable<TEntity> entities, EntityState state)
        {
            _uow.Dal<TEntity, TValidator>().EntityStateChange(entities, state);
        }

        public TEntity get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity, TValidator>().get(filter, includes);

        }
    }
}
