
using System;

namespace Polymorphism
{
    class Calculate
    {
       public string area(int side)
        {
            int ar = side * side;

            return string.Format("square area:{0}", ar);
        }

        public string area(int l,int b)
        {
            int ar = l * b;
            return string.Format("rectangle area:{0}", ar);
        }
    }
}
