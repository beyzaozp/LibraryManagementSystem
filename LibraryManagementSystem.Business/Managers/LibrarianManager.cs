using LibraryManagementSystem.Business.Managers.Base;
using LibraryManagementSystem.Business.Services;
using LibraryManagementSystem.DataAccess.UnitOfWork;
using LibraryManagementSystem.DataAccess.Validations;
using LibraryManagementSystem.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Managers
{
    public class LibrarianManager : BaseManager<Librarian, LibrarianValidator>, ILibrarianService
    {
        public LibrarianManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
