using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Class1
    {
        public string values(string[] name)
        {
            string s1 = string.Join(" ", name);
            return s1;
        }
        public string Name(string firstName, string lastName)
        {

            StringBuilder sb = new StringBuilder(firstName);
            sb.Append(lastName);
            return sb.ToString();

        }
        public void Method1(string var)
        {  
                char[] letters = var.ToCharArray();
                foreach (Char c in letters)
                {
                    Console.WriteLine(c);
                }

                    
        }

    }
}
