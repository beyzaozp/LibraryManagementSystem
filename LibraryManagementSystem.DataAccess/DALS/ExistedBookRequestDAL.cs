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
    public class ExistedBookRequestDAL : Repository<ExistedBookRequest>, IExistedBookRequestDAL
    {
        public ExistedBookRequestDAL(DbContext context) : base(context)
        {
        }
    }
}
