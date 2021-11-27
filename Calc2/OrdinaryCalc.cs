using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
    public class OrdinaryCalc : AbstractCalc 
    {
        public OrdinaryCalc()
        {

        }
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public override double Add()
        {
            return Number1 + Number2;
        }

        public override double Sub()
        {
            return Number1 - Number2;
        }

        public override double Mul()
        {
            return Number1 * Number2;
        }

        public override double Div()
        {
            return Number1 / Number2;
        }
    }
}
