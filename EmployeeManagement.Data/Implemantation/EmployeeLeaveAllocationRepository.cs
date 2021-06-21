using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Implemantation
{
    public class EmployeeLeaveAllocationRepository : Repository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationRepository
    {
        private readonly EmployeeManagementContext _ctx;

        public EmployeeLeaveAllocationRepository(EmployeeManagementContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
