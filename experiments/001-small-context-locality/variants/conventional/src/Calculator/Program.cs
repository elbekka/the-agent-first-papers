using Calculator.Application;
using Calculator.Domain;
using Calculator.Factories;
using Calculator.Validation;

IOperationFactory operationFactory = new OperationFactory();
ICalculationService calculationService = new CalculationService(operationFactory);

Console.Write("Introduce el primer número: ");
if (!NumberValidator.TryParse(Console.ReadLine(), out var left))
{
    Console.WriteLine("Número no válido.");
    return;
}

Console.Write("Introduce el segundo número: ");
if (!NumberValidator.TryParse(Console.ReadLine(), out var right))
{
    Console.WriteLine("Número no válido.");
    return;
}

var result = calculationService.Calculate(OperationType.Addition, left, right);
Console.WriteLine($"Resultado: {result}");
