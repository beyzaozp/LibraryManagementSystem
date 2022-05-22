using LibraryManagementSystem.Entities.Tables;
using LibraryManagementSystem.Entities.Tables.Base;
using System;

namespace LibraryManagement.Entities.Tables
{
    public class Borrow: EntityBase
    {
        public Guid BookID { get; set; }
        public virtual Book Book { get; set; }//??
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        //Alttakini neden yazdığımı bilmiyom 
       //   public decimal  BookNo { get; set; }
   
        public DateTime BorrowDate { get; set; }
        public DateTime? DeliverDate { get; set; }
     //   public virtual Book BookPrice { get; set; }
        // public bool IsDelivery { get; set; }
            
    }
}
