using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsDemo
{
    class Exam
    {
        string examCode, centerCode, examName,examInvizilator;
        int hallTicketNumber;
        public void ExamData(string ec,string cc,string en,string ei,int htn)
        {
            examCode = ec;
            centerCode = cc;
            examName = en;
            examInvizilator = ei;
            hallTicketNumber = htn;
        }
        public void showData()
        {
            Console.WriteLine("Exam code:" + examCode + "\n" + " centerCode:" + centerCode + "\n" + " examName:" + examName + "\n" + " examInvizilator:" + examInvizilator + "\n" + " hallTicketNumber:" + hallTicketNumber);

        }
    }
}
