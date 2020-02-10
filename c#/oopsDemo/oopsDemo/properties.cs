using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsDemo
{
    class properties
    {
        string firstname;
        string lastname;
        int idno;
        string course;
        DateTime joindate;
        public properties() { }

        public properties(string firstname,string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;

        }
        public string Name
        {
            get { return String.Format(" {0} {1}", firstname, lastname); }
           
        }
        public int IdNo
        {
            get { return idno; }
            set { idno = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }

        }
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }

    }
}
