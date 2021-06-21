using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveRequestVM : BaseVM
    {
        public string ApprovedEmployeeId { get; set; }
       
        public EmployeeVM ApprovedEmployee { get; set; }


        public string RequestingEmployeeId { get; set; }
      
        public EmployeeVM RequestingEmployee { get; set; }

        public int EmpoyeeLeaveTypeId { get; set; }
        
        public EmployeeLeaveAllocationVM EmployeeLeaveType { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateTime RequestDated { get; set; }

        [MaxLength(300, ErrorMessage="Use Max 300 character")]
        [Display(Name ="Request Explanation")]
        public string RequestComments { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
