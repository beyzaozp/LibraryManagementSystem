using LibraryManagementSystem.Business.Managers.Base;
using LibraryManagementSystem.Business.Services;
using LibraryManagementSystem.DataAccess.UnitOfWork;
using LibraryManagementSystem.DataAccess.Validations;
using LibraryManagementSystem.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Managers
{
    public class BookManager : BaseManager<Book, BookValidator>, IBookService
    {
        public BookManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
