using Calculator.Domain;

namespace Calculator.Factories;

public sealed class OperationFactory : IOperationFactory
{
    public IOperation Create(OperationType type) => type switch
    {
        OperationType.Addition => new AdditionOperation(),
        _ => throw new NotSupportedException($"Operation type '{type}' is not supported.")
    };
}
