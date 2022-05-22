using LibraryManagementSystem.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Functions
{
    public static class EntityBaseInfo
    {
        public static void Add(DbContext context)
        {

            foreach (var entry in context.ChangeTracker.Entries())
            {
                EntityBase changingEntity = (EntityBase)entry.Entity;

                switch (entry.State)
                {
                    case EntityState.Added:
                        if (changingEntity.ID == Guid.Empty)
                        {
                            changingEntity.ID = Guid.NewGuid();
                        }
                        changingEntity.EklemeTarihi = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        changingEntity.DuzenlenmeTarihi = DateTime.Now;
                        break;
                }
            }
        }
    }
}
