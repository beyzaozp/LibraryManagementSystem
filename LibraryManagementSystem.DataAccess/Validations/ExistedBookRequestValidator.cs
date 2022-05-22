using FluentValidation;
using LibraryManagement.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Validations
{
    public class ExistedBookRequestValidator: AbstractValidator<ExistedBookRequest>
    {
        public ExistedBookRequestValidator()
        {

        }
    }
}
