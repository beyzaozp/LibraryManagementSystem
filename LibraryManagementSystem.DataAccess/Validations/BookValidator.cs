using FluentValidation;
using LibraryManagementSystem.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Validations
{
    public class BookValidator: AbstractValidator<Book>
    {
        public BookValidator()
        {
            
        }
    }
}
