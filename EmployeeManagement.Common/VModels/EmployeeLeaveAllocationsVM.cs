using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveAllocationsVM :BaseVM
    {
        public int NumberofDays { get; set; }

        public DateTime DateCreated { get; set; }

        public int Period { get; set; }

        public string EmployeeId { get; set; }
       
        public EmployeeVM EmployeeVMm{ get; set; }


        public int EmployeeLeaveTypeId { get; set; }
        
        public EmployeeLeaveAllocationVM EmployeeLeaveTypeVm { get; set; }
    }

    
}
