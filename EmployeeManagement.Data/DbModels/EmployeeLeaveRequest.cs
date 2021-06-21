using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.DbModels
{
   public class EmployeeLeaveRequest : BaseEntity
    {
        public string ApprovedEmployeeId { get; set; }
        [ForeignKey("ApprovedEmployeeId")]
        public Employee ApprovedEmployee { get; set; }


        public string RequestingEmployeeId { get; set; }
        [ForeignKey ("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }

        public int EmpoyeeLeaveTypeId { get; set; }
        [ForeignKey("EmlpoyeeLeaveTypeId")]
        public EmployeeLeaveType EmployeeLeaveType { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateTime RequestDated { get; set; }

        public string RequestComments { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

    }
}
