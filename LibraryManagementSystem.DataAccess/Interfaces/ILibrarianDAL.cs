using LibraryManagementSystem.DataAccess.Interfaces.Base;
using LibraryManagementSystem.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Interfaces
{
    public interface ILibrarianDAL: IRepository<Librarian>
    {
    }
}
