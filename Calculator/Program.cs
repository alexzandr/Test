using System;
using System.Text.RegularExpressions;
using Calculator.Core;

namespace Calculator
{
    internal class Program
    {
        //Goal: we want to create calculator which always operate with only 2 operands and 1 mathematical operation between 2 operands
        //For now we support only 4 operations '+','-','*','/', but we need to have an easy way to add new operation and maping on it
        //We also suspect that later we want to have ability to fill mapping in another way 
        //(out of code, example with config file binding on assemblies with type names or folder with assemblies, which has types with correspond interface)
        //To add new operation we need to add new operation class which implement interface

        //Assumptions:
        //we consider that user always pass correct string
        //like this '1.222+3.222'
        //we concider that user knows that he shouldn't devide by zero
        //no any additional verifications
        //no unit tests


        //Extra details: lazy initialization for Operations : only used operations will be instanced
        //in current case it has no big sense, but if initialization is a huge operation - can be useful
        //We  provide BaseOperationResolver - abstract class wich has logic with getting operation from mapping, but has not implement final maping
        //We  provide DefaultOperationResolver, which use maping in method BuildOperationsMap to manual fill 
        //But there are a lot of different methods
        private static void Main()
        {
            //read string
            var inputString = Console.ReadLine();

            //we will use this pattern for both cases - extract operation and 
            var pattern = "[-,+,/,*]";
            
            // extract operands and operator 
            var operands = Regex.Split(inputString, pattern);
            var operation = Regex.Match(inputString, pattern).ToString();
            
            //convert strings to double values
            var x = Convert.ToDouble(operands[0]);
            var y = Convert.ToDouble(operands[1]);
            
            //calculate
            var executor = new CalculatorExecutor();
            Console.WriteLine(executor.Execute(operation, x, y));
        }
    }
}
