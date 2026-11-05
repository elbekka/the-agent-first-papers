using Calculator.Domain;

namespace Calculator.Application;

public interface ICalculationService
{
    double Calculate(OperationType type, double left, double right);
}
