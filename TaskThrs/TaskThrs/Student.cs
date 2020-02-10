using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThrs
{
   class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Sbranch { get; set; }
        
        public List<Student> ListDemo(List<Student> s)
        {
            var b = from a in s orderby a.Sid select a;
            return b.ToList();
        }
    }
}
