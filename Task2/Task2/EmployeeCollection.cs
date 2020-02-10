using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class EmployeeCollection
    {
        List<Employee> l1 = new List<Employee>();
        public void AddEmp(int EmpID, string Ename,string Edesig,double Esal)
        {
            l1.Add(new Employee { EmpID =EmpID , Ename =Ename , Edesig =Edesig , Esal =Esal  });
        
        }
        public void showEmp()
        {
            foreach(Employee e in l1)
            {
                
                 Console.WriteLine("Employeeid:{0} \n EmployeeName:{1} \n EmployeeDesignation :{2} \n Employeesalary:{3}",e.EmpID,e.Ename,e.Edesig,e.Esal);
                 Console.WriteLine("\n");
            }
        }
        public void removeEmp(int i)
        {

            l1.RemoveAt(i);
        }
    }
}
