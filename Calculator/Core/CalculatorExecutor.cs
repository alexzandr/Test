using Calculator.Interfaces;

namespace Calculator.Core
{
    //No needs any changes here in case of adding new ariphmetical operations
    //by default we use DefaultOperationResolver for default constructor
    //but we also can instance executor with any other operation resolver
    public class CalculatorExecutor
    {
        private readonly IOperationResolver _operationResolver;

        public CalculatorExecutor(IOperationResolver resolver)
        {
            _operationResolver = resolver;
        }

        public CalculatorExecutor() : this(new DefaultOperationResolver())
        {
            
        }

        public double Execute(string operation, double x, double y)
        {
            var atomicOperation = _operationResolver.GetOperation(operation);
            return atomicOperation.Execute(x, y);
        }
    }
}
