using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount
            {
                accountNumber = 30978992045,
                balance = 10000.50,
                AccountHolder = new Customer { cid = 144, name = "rohith", address = "jawahar nagar colony markapuram" }
            };
            Console.WriteLine("Account number is:{0} \n Account Balance is:{1} \n Customer Id is:{2} \n Customer Name is:{3} \n Customer Address is:{4}",ba.accountNumber,ba.balance,ba.AccountHolder.cid, ba.AccountHolder.name,ba.AccountHolder.address);
            FixedAccount fa = new FixedAccount();
            Console.WriteLine("interst amount with extra 3% interest is"+" "+fa.interestAmount( 2, 2));
           
            Console.ReadKey();
        }
    }
}
