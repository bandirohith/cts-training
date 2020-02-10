using System;

namespace Operator_overloading
{
    class Demo
    {
        public int a1, a2;

        public static Demo operator +(Demo x, Demo y)
        {
            Demo d = new Demo();
            d.a1 = x.a1 + x.a2;
            d.a2 = y.a1 + y.a2;
            return d;
        }
    }
}
