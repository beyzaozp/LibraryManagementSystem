
using LibraryManagementSystem.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities.Tables
{
    public class Request: EntityBase
    {
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public string BookName { get; set; }
    }
}
