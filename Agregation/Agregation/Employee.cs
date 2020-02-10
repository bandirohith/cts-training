using System;
using System.Collections.Generic;
using System.Text;

namespace Agregation
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public Department Dept { get; set; }

       

      /* public Employee(int id,string name,Department departmentName)
        {
            this.id = id;
            this.name = name;
            this.departmentName = departmentName;
            
        }*/

       /* public void Show()
        {
            Console.WriteLine(id +" "+ name +" "+ dept.id+" " +dept.departmentName);
        }*/
    }
}
