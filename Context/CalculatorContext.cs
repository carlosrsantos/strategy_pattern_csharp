using Calculator.Strategy;

namespace Calculator.Context;

public class CalculatorContext
{
    private readonly IOperation _operation;

    public CalculatorContext(IOperation operation)
    {
        _operation = operation;
    }

    public double Calculate(double number1, double number2)
    {
       return _operation.Operation(number1, number2);
    }
}