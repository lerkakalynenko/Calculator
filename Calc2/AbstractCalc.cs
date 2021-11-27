namespace Calc2
{
    public abstract class  AbstractCalc
    {
        public string Make { get; set; }
        public abstract double Add();
        public abstract double Div();
        public abstract double Mul();
        public abstract double Sub();
    }
}
