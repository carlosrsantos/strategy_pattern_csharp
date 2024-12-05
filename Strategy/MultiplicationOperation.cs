using Calculator.Strategy;

namespace Strategy;

public class MultiplicationOperation: IOperation
{
    public double Operation(double left, double right)
    {
        return left * right;
    }
}