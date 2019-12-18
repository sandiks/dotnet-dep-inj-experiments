using System;
using DependencyInjSample.Interfaces;

namespace DependencyInjSample.Models
{
    #region snippet1
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid id)
        {
            OperationId = id;
        }

        public Guid OperationId { get; private set; }
    }
    #endregion
}
