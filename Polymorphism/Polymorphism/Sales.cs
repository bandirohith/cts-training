using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Sales
    {
        string productName;
        int quantity;
        double price;
        static double totalSales; 
         public Sales() { }

        public Sales(string productName,int quantity,double price)
        {
            this.productName = productName;
            this.quantity = quantity;
           this.price = price;
            totalSales += quantity * price;
        }

        public double SalesAmount()
        {
            
            return totalSales;
            
        }
        
    }
}
