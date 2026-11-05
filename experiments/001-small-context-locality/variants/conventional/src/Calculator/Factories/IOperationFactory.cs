using Calculator.Domain;

namespace Calculator.Factories;

public interface IOperationFactory
{
    IOperation Create(OperationType type);
}
