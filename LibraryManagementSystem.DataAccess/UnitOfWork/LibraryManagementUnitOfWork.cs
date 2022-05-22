using LibraryManagementSystem.DataAccess.Context.LibraryManagement;
using LibraryManagementSystem.DataAccess.DALS;
using LibraryManagementSystem.DataAccess.Functions;
using LibraryManagementSystem.DataAccess.Interfaces;
using LibraryManagementSystem.DataAccess.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.UnitOfWork
{
    public class LibraryManagementUnitOfWork : IUnitOfWork
    {
        private readonly LibraryManagementContext _context;
        private bool disposedValue;
        public IBookDAL BookDAL { get; set; }
        public IBorrowDAL BorrowDAL { get; set; }
        public IExistedBookRequestDAL ExistedBookRequestDAL { get; set; }
        public IGuestDAL GuestDAL { get; set; }
        public ILibrarianDAL LibrarianDAL { get; set; }
        public IRequestDAL RequestDAL { get; set; }
        public IStudentDAL StudentDAL { get; set; }
        public IUserDAL UserDAL { get; set; }

        public LibraryManagementUnitOfWork(string connectionString)
        {
            if (connectionString == null)
            {
                _context = new LibraryManagementContext(ConnectionStringInfo.get());

            }

            else
            {
                _context = new LibraryManagementContext(connectionString);
            }
            _context = new LibraryManagementContext(connectionString);
            BookDAL = new BookDAL(_context);
            BorrowDAL = new BorrowDAL(_context);
            ExistedBookRequestDAL = new ExistedBookRequestDAL(_context);
            GuestDAL = new GuestDAL(_context);
            LibrarianDAL = new LibrarianDAL(_context);
            RequestDAL = new RequestDAL(_context);
            StudentDAL = new StudentDAL(_context);
            UserDAL = new UserDAL(_context);
        }

        public bool Commit()
        {
            EntityBaseInfo.Add(_context);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }

        public bool HasChanges()
        {
            throw new NotImplementedException();
        }

        IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
            throw new NotImplementedException();
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
        // ~LibraryManagementUnitOfWork()
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
    }
}
