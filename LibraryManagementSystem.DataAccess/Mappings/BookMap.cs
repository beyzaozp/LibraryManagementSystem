using LibraryManagementSystem.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    public class BookMap: EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            Property(p => p.Name).HasMaxLength(50);
            Property(p => p.Author).HasMaxLength(50);
            Property(p => p.Location).HasMaxLength(50);

            ToTable("Books");
            Property(p => p.BarcodeNo).HasColumnName("bookBarcodeno");
            Property(p => p.Author).HasColumnName("bookAuthor");
            Property(p => p.Name).HasColumnName("bookName");
            Property(p => p.Location).HasColumnName("bookLocation");
        }
    }
}
