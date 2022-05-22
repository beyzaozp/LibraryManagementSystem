using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Context.Base
{
    public class BaseContext<TContext>: DbContext where TContext : DbContext, new()
    {
        private static string connectionString;

        public BaseContext() : base(connectionString)
        {

        }
        public BaseContext(string Connectionstring) : base(Connectionstring)
        {
            Configuration.LazyLoadingEnabled = false;
            connectionString = Connectionstring;
        }
    }
}
