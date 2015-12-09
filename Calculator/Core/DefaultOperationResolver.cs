using Calculator.Operations;

namespace Calculator.Core
{

    //It's default operation resolver which fill operations 
    internal sealed class DefaultOperationResolver : BaseOperationResolver
    {
        protected override void BuildOperationsMap()
        {
            OperationTypes.Add("+", typeof(PlusOperation));
            OperationTypes.Add("-", typeof(MinusOperation));
            OperationTypes.Add("*", typeof(MultiOperation));
            OperationTypes.Add("/", typeof(DivideOperation)); 
        }
    }
}
