using LibraryManagement.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    public class RequestMap: EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            ToTable("Requests");
            Property(p => p.UserID).HasColumnName("UserID");
            Property(p => p.BookName).HasColumnName("UserSurname");
        }
    }
}
