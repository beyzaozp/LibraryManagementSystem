using LibraryManagementSystem.Business.Managers;
using LibraryManagementSystem.Business.Services;
using LibraryManagementSystem.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Worker
{
    public class LibraryManagementWorker : IWorker
    {
        private bool disposedValue;
        private IUnitOfWork _uow;

        public IBookService bookService { get; set; }
        public IBorrowService borrowService { get; set; }
        public IGuestService guestService { get; set; }
        public ILibrarianService librarianService { get; set; }
        public IRequestService requestService { get; set; }
        public IExistedBookRequestService existedBookRequestService { get; set; }
        public IStudentService studentService { get; set; }
        public IUserService userService { get; set; }

        public LibraryManagementWorker(string connectionstring = null)
        {
            _uow = new LibraryManagementUnitOfWork (connectionstring);
            bookService = new BookManager(_uow);
            borrowService = new BorrowManager(_uow);
            guestService = new GuestManager(_uow);
            librarianService = new LibrarianManager(_uow);
            requestService = new RequestManager(_uow);
            userService = new UserManager(_uow);
            studentService = new StudentManager(_uow);
            existedBookRequestService = new ExistedBookRequestManager(_uow);

        }
        public bool Commit()
        {
            return _uow.Commit();
        }

        public void DetectChanges()
        {
            _uow.DetectChanges();
        }

        public bool HasChanges()
        {
            return _uow.HasChanges();
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
        // ~LibraryManagementWorker()
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
