using LibraryManagement.Entities.Tables;
using LibraryManagementSystem.DataAccess.Context.Base;
using LibraryManagementSystem.DataAccess.Mappings;
using LibraryManagementSystem.Entities.Tables;
using LibraryManagementSystem.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Context.LibraryManagement
{
    public class LibraryManagementContext : BaseContext<LibraryManagementContext>
    {
        public LibraryManagementContext()
        {
        }

        public LibraryManagementContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibraryManagementContext, LibraryManagementConfiguration>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<ExistedBookRequest> ExistedBookRequests { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Types<EntityBase>().Configure(p =>
            {
                p.Property(e => e.Aciklama).HasMaxLength(300);
                p.Property(e => e.ID).HasColumnName("ID");
                p.Property(e => e.Aciklama).HasColumnName("Aciklama");
                p.Property(e => e.DuzenlenmeTarihi).HasColumnName("DuzenlenmeTarihi");
                p.Property(e => e.EklemeTarihi).HasColumnName("EklemeTarihi");
            });
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new ExistedBookRequestMap());
            modelBuilder.Configurations.Add(new GuestMap());
            modelBuilder.Configurations.Add(new LibrarianMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new UserMap());

            modelBuilder.Entity<Borrow>().HasRequired(e => e.Book).WithOptional().Map(p => p.MapKey("BookID"));//1-0 ilişki
            modelBuilder.Entity<Borrow>().HasRequired(e => e.User).WithOptional().Map(p => p.MapKey("UserID"));//1-0 ilişki
            modelBuilder.Entity<Borrow>().HasRequired(e => e.User).WithMany(e=>e.BorrowedBooks).HasForeignKey(e=>e.UserID);//1 e çok ilişki

            modelBuilder.Entity<ExistedBookRequest>().HasRequired(e => e.Book).WithOptional().Map(p => p.MapKey("BookID"));//1-0 ilişki
            modelBuilder.Entity<ExistedBookRequest>().HasRequired(e => e.Borrow).WithOptional().Map(p => p.MapKey("DeliveryDate"));//1-0 ilişki
            
            modelBuilder.Entity<Request>().HasRequired(e => e.User).WithOptional().Map(p => p.MapKey("UserID"));//1-0 ilişki
        }
    }
}
