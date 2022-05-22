using LibraryManagement.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    public class ExistedBookRequestMap: EntityTypeConfiguration<ExistedBookRequest>
    {
        public ExistedBookRequestMap()
        {
            ToTable("ExistedBookRequests");
            Property(p => p.BookID).HasColumnName("RequestBookID");
            Property(p => p.UserID).HasColumnName("RequestUserID");
            Property(p => p.DeliveryDate).HasColumnName("RequestDeliveryDate");
        }
    }
}
