using Calculator.Features.Add;

Console.Write("First number: ");
var left = decimal.Parse(Console.ReadLine()!);

Console.Write("Second number: ");
var right = decimal.Parse(Console.ReadLine()!);

Console.WriteLine($"Result: {AddOperation.Execute(left, right)}");
