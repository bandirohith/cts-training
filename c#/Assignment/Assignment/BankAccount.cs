using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class BankAccount
    {
        public long accountNumber { get; set; }
        public double balance { get; set; }
        public Customer AccountHolder { get; set; }

        public  virtual double interestAmount( int t, int r)
        {
            double simpleInterest = (balance * t * r) / 100;
            return simpleInterest;
        }

    }
}
