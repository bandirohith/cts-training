﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibCalculation
{
    public class Calculation
    {
        public int No1 { get; set; }
        public int No2 { get; set; }
        public string Add()
        {
            return string.Format("sum={0}", No1 + No2);

        }
        public string Difference()
        {
            return string.Format("Differenc={0}", No1- No2);
        }
        public string Multiply()
        {
            return string.Format("Multiply={0}", No1 * No2);
        }
        public string Division()
        {
            return string.Format("Division={0}", No1 / No2);
        }
    }
}
