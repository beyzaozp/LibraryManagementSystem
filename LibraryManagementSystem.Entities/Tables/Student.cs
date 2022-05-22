using LibraryManagement.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities.Tables
{
    public class Student: User
    {
        public string StudentNo { get; set; }
        public float Debt { get; set; }
    }
}
