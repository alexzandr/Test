using Calculator.Interfaces;

namespace Calculator.Operations
{
    public class MultiOperation : IOperation
    {
        public double Execute(double x, double y)
        {
            return x * y;
        }
    }
}
