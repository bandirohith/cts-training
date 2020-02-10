using System;
using System.Collections.Generic;
using System.Text;

namespace Agregation
{
    class Program
    {
        static void Main(string[] args)
        {
            // empDeptAgg();
            //custProdAgg();
            empDeptConst();
            Console.ReadKey();
        }

        private static void empDeptConst()
        {
            Department d = new Department(100, "cse");
            Employee e = new Employee(10, "rohith", d);

            e.Show();
        }

        private static void custProdAgg()
        {
            Product p = new Product()
            {
                pid = 101,
                name = "sugar"
                ,
                price = 50.50,
                Theory = new Category { cid = 144, description = "i want sugar" }
            };
            Console.WriteLine("{0}\t{1}\n{2}\t{3}", p.pid, p.name, p.price, p.Theory.cid, p.Theory.description);
        }

        private static void empDeptAgg()
        {
            Employee e = new Employee
            {
                id = 100,
                name = "rohith",
                Dept = new Department { departmentName = "cse", id = 10 }
            };
            Console.WriteLine("{0}\t{1}\n{2}\t{3}", e.id, e.name, e.Dept.id, e.Dept.departmentName);
        }
    }
}
