using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OrdinaryCalc
    {
        public OrdinaryCalc()
        {

        }
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public double Add()
        {
            return Number1 + Number2;
        }

        public double Sub()
        {
            return Number1 - Number2;
        }

        public double Mul()
        {
            return Number1 * Number2;
        }


    }
}
