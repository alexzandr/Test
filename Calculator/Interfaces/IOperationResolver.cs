namespace Calculator.Interfaces
{
    public interface IOperationResolver
    {
        IOperation GetOperation(string operation);
    }
}