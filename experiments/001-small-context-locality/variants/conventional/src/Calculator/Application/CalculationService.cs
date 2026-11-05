using Calculator.Domain;
using Calculator.Factories;
using Calculator.Validation;

namespace Calculator.Application;

public sealed class CalculationService : ICalculationService
{
    private readonly IOperationFactory _operationFactory;

    public CalculationService(IOperationFactory operationFactory)
    {
        _operationFactory = operationFactory;
    }

    public double Calculate(OperationType type, double left, double right)
    {
        NumberValidator.EnsureFinite(left, nameof(left));
        NumberValidator.EnsureFinite(right, nameof(right));
        return _operationFactory.Create(type).Execute(left, right);
    }
}
