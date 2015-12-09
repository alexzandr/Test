using Calculator.Interfaces;

namespace Calculator.Operations
{
    public class MinusOperation : IOperation
    {
        public double Execute(double x, double y)
        {
            return unchecked(x - y);
        }
    }
}
