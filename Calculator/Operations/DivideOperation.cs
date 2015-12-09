using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Operations
{
    public class DivideOperation : IOperation
    {
        public double Execute(double x, double y)
        {
            return unchecked (x / y);
        }
    }
}
