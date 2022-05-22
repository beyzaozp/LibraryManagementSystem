using LibraryManagementSystem.DataAccess.DALS.Base;
using LibraryManagementSystem.DataAccess.Interfaces;
using LibraryManagementSystem.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.DALS
{
    public class LibrarianDAL : Repository<Librarian>, ILibrarianDAL
    {
        public LibrarianDAL(DbContext context) : base(context)
        {
        }
    }
}
