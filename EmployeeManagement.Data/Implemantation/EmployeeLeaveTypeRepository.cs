using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Implemantation
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly EmployeeManagementContext _ctx;

        public EmployeeLeaveTypeRepository(EmployeeManagementContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

    }
}
