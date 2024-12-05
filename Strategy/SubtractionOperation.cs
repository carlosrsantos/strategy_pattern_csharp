using Calculator.Strategy;

namespace Strategy;

public class SubtractionOperation: IOperation
{
    public double Operation(double left, double right)
    {
        return left - right;
    }
}