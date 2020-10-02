using CalculationEngine.Models;

namespace CalculationEngine.Interfaces
{
    public interface IMathEngine
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        decimal Divide(int a, int b);
        decimal Add(decimal a, decimal b);
        decimal Subtract(decimal a, decimal b);
        decimal Multiply(decimal a, decimal b);
        decimal Divide(decimal a, decimal b);
        decimal Calculate(CalculateOperation calculateOperation);
    }
}