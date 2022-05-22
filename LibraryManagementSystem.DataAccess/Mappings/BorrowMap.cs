using LibraryManagement.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    public class BorrowMap: EntityTypeConfiguration<Borrow>
    {
        public BorrowMap()
        {

            ToTable("Borrows");
            Property(p => p.BookID).HasColumnName("borrowedBookID");
            Property(p => p.UserID).HasColumnName("borrowerUserID");
            Property(p => p.BorrowDate).HasColumnName("BorrowDate");
            Property(p => p.DeliverDate).HasColumnName("DeliveryDate");
            //Property(p => p.BorrowDate).HasColumnName("borrowDate");
            //Property(p => p.IsDelivery).HasColumnName("borrowIsDelivery");
        }
    }
}
