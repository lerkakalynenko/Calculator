using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
    public abstract class  AbstractCalc
    {
        public int Make { get; set; }
        public abstract double Add();
        public abstract double Div();
        public abstract double Mul();
        public abstract double Sub();
    }
}
