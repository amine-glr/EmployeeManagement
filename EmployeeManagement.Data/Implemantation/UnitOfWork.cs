using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Implemantation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _ctx;

        public UnitOfWork(EmployeeManagementContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequest = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveType = new EmployeeLeaveTypeRepository(_ctx);

        }

        public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; private set; }

        public IEmployeeLeaveRequestRepository employeeLeaveRequest { get; private set; }

        public IEmployeeLeaveTypeRepository employeeLeaveType { get; private set; }



        public void Dispose()
        {
            _ctx.SaveChanges();
        }

        public void Save()
        {
            _ctx.Dispose();
        }
    }
}
