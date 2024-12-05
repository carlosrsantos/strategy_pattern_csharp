using Strategy;

namespace Calculator.Strategy;

public class AdditionOperation: IOperation
{
    public double Operation(double left, double right)
    {
        return left + right;
    }
}