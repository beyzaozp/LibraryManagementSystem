using FluentValidation;
using LibraryManagementSystem.DataAccess.Interfaces.Base;
using LibraryManagementSystem.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Dal<TEntity, TValidator>() where TEntity : class, IEntity, new() where TValidator : IValidator, new();

        
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}
