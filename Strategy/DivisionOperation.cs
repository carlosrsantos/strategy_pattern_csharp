namespace Calculator.Strategy;

public class DivisionOperation: IOperation
{
    public double Operation(double left, double right)
    {
        return left / right;
    }
}