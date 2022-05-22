using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Context.LibraryManagement
{
    public class LibraryManagementConfiguration : DbMigrationsConfiguration<LibraryManagementContext>
    {
        public LibraryManagementConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
