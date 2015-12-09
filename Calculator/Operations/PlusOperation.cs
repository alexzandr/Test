using Calculator.Interfaces;

namespace Calculator.Operations
{
    public class PlusOperation : IOperation
    {
        public double Execute(double x, double y)
        {
            return x + y;
        }
    }
}
