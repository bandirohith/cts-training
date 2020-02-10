using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsDemo
{
    class Scale
    {
        double centimeter;

        public double Inch
        {
            get
            {
                
                return centimeter / 2.54;
            }

            set
            {
                centimeter = value*2.54;
            }
        }
        public void showcent()
        {
            Console.WriteLine("Centimeter:{0}",centimeter);
        }
        
    }
}
