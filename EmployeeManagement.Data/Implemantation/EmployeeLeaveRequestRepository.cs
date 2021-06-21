


using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;

namespace EmployeeManagement.Data.Implemantation
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequestRepository
    {
        private readonly EmployeeManagementContext _ctx;

        public EmployeeLeaveRequestRepository(EmployeeManagementContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
