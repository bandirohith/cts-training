using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
       public int EmpID;
       public string Ename;
        public string Edesig;
        public double Esal;

        public void getdata() {
            Console.WriteLine("Enter emp id:");
            EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter emp name:");
            Ename = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter emp desig:");
            Edesig = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter emp sal:");
            Esal = double.Parse(Console.ReadLine());
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            EmployeeCollection ec = new EmployeeCollection();

            Console.WriteLine("enter employee details");
            p.getdata();
            ec.AddEmp(p.EmpID,p. Ename, p.Edesig,p. Esal);

            Console.WriteLine("enter employee details");

            p.getdata();
            ec.AddEmp(p.EmpID, p.Ename, p.Edesig, p.Esal);



           

            
            ec.showEmp();
            Console.WriteLine("enter an index to remove");
            
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ec.removeEmp(i);
            ec.showEmp();
            Console.ReadKey();
        }
    }
}
