using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class AdvancedCalc: OrdinaryCalc
    {
        public AdvancedCalc()
        {

        }
         public double Cos()
        {
            double number = Number1 * Math.PI / 180;
            return Math.Cos(number);
        }
    }
}
