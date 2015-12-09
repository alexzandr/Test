using System;
using System.Collections.Generic;
using System.Reflection;
using Calculator.Interfaces;

namespace Calculator.Core
{

    //It's base abstract operation resolver with 'lazy' initialization for instances for operations
    internal abstract class BaseOperationResolver : IOperationResolver
    {
        protected readonly IDictionary<string, Type> OperationTypes;

        private readonly IDictionary<string, IOperation> _instantiatedOperations;

        internal BaseOperationResolver()
        {
            this.OperationTypes = new Dictionary<string, Type>();
            this._instantiatedOperations = new Dictionary<string, IOperation>();
            this.BuildOperationsMap();
        }

        public IOperation GetOperation(string operation)
        {
            if (this._instantiatedOperations.ContainsKey(operation))
            {
                return this._instantiatedOperations[operation];
            }

            try
            {
                ConstructorInfo constructor = OperationTypes[operation].GetConstructor(new Type[0]);

                if (constructor == null)
                {
                    throw new ApplicationException("The requested operation has wrong implementation");

                }
                IOperation operationExecutor = (IOperation) constructor.Invoke(null);
                _instantiatedOperations.Add(operation, operationExecutor);
                return operationExecutor;
                
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException
                    ("The requested operation is not registered");
            }
        }

        protected abstract void BuildOperationsMap();
    }
}
