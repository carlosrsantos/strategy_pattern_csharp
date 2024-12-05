namespace Calculator.Strategy;

public interface IOperation
{
    double Operation(double left, double right);
}