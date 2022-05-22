
using LibraryManagementSystem.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Tables
{
    public class Book: EntityBase
    {
        public Guid BarcodeNo { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Location { get; set; }
       // public virtual CategoryType Category { get; set; }
      // ??  public Int32 BookPrice { get; set; }
    }
}
