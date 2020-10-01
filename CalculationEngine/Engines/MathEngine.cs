using System;

namespace CalculationEngine
{
    public class MathEngine : IMathEngine
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Divide(int a, int b)
        {
            return (decimal)a / (decimal)b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }
    }
}