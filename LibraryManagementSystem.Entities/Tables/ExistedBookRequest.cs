using LibraryManagementSystem.Entities.Tables;
using System;

namespace LibraryManagement.Entities.Tables
{
    public class ExistedBookRequest: Request 
    {
        public Guid BookID { get; set; }

        public virtual Book Book { get; set; }

        public Guid DeliveryDate { get; set; }

        public virtual Borrow Borrow { get; set; }
    }
}
