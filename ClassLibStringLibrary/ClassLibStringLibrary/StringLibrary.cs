using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibStringLibrary
{
    public class StringLibrary
    {
        public static bool StartWithUpper(String str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return false;

            }
            char ch = str[0];
            return char.IsUpper(ch);
        }
        public static bool StartWithLowe(String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;

            }
            char ch = str[0];
            return char.IsLower(ch);
        }
        public static bool StartWithNumber(String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;

            }
            char ch = str[0];
            return char.IsNumber(ch);
        }
    }
}
