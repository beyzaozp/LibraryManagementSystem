﻿using LibraryManagement.Entities.Tables;
using LibraryManagementSystem.Business.Managers.Base;
using LibraryManagementSystem.Business.Services;
using LibraryManagementSystem.DataAccess.UnitOfWork;
using LibraryManagementSystem.DataAccess.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Managers
{
    public class ExistedBookRequestManager : BaseManager<ExistedBookRequest, ExistedBookRequestValidator>, IExistedBookRequestService
    {
        public ExistedBookRequestManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
