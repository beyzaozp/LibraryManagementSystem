using LibraryManagement.Entities.Tables;
using LibraryManagementSystem.DataAccess.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Interfaces
{
    public interface IRequestDAL: IRepository<Request>
    {
    }
}
