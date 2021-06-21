using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveAllocationVM : BaseVM
    {
        [Required]
        public string Name { get; set; }

        public int Days { get; set; }

        public DateTime DateCreated { get; set; }

        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}
