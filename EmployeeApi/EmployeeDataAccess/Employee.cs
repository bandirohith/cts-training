using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccess
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public long  SSN { get; set; }
        public double EmpSalary { get; set; }
        public DateTime Dob { get; set; }
        public int DeptId { get; set; }
    }
}
