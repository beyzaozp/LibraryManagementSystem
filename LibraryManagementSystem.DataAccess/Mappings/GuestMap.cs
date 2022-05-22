using LibraryManagementSystem.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    public class GuestMap: EntityTypeConfiguration<Guest>
    {
        public GuestMap()
        {
            Property(p => p.Name).HasMaxLength(50);
            Property(p => p.Surname).HasMaxLength(50);
            Property(p => p.Email).HasMaxLength(50);
            Property(p => p.Password).HasMaxLength(50);
            Property(p => p.Phone).HasMaxLength(50);
            Property(p => p.UserType).HasMaxLength(50);

            ToTable("Guests");
            Property(p => p.Name).HasColumnName("UserName");
            Property(p => p.Surname).HasColumnName("UserSurname");
            Property(p => p.Email).HasColumnName("UserEmail");
            Property(p => p.Password).HasColumnName("UserPassword");
            Property(p => p.Phone).HasColumnName("UserPhone");
            Property(p => p.UserType).HasColumnName("UserType");
        }

    }
}
