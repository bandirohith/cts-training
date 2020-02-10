using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class FixedAccount : BankAccount
    {
        public override double interestAmount( int t, int r)
        {
            double simpleInterest = (balance * t * r) / 100;
           // simpleInterest+=(simpleInterest/100)*3;
            return simpleInterest;
        }
    }
}
