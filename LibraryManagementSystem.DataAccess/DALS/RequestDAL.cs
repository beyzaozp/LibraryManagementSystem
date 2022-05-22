using LibraryManagement.Entities.Tables;
using LibraryManagementSystem.DataAccess.DALS.Base;
using LibraryManagementSystem.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.DALS
{
    public class RequestDAL : Repository<Request>, IRequestDAL
    {
        public RequestDAL(DbContext context) : base(context)
        {
        }
    }
}
