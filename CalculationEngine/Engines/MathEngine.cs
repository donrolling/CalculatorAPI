using CalculationEngine.Interfaces;
using CalculationEngine.Models;
using System;

namespace CalculationEngine.Engines
{
    public class MathEngine : IMathEngine
    {
        public decimal Calculate(CalculateDecimalsOperation calculateOperation)
        {
            switch (calculateOperation.Operation)
            {
                case Operation.Add:
                    return Add(calculateOperation.InputA, calculateOperation.InputB);

                case Operation.Subtract:
                    return Subtract(calculateOperation.InputA, calculateOperation.InputB);

                case Operation.Multiply:
                    return Multiply(calculateOperation.InputA, calculateOperation.InputB);

                case Operation.Divide:
                    return Divide(calculateOperation.InputA, calculateOperation.InputB);

                default:
                    break;
            }
            throw new Exception("Operation Not Found");
        }

        public decimal Calculate(CalculateIntegersOperation calculateOperation)
        {
            switch (calculateOperation.Operation)
            {
                case Operation.Add:
                    return Add(calculateOperation.InputA, calculateOperation.InputB);

                case Operation.Subtract:
                    return Subtract(calculateOperation.InputA, calculateOperation.InputB);

                case Operation.Multiply:
                    return Multiply(calculateOperation.InputA, calculateOperation.InputB);

                case Operation.Divide:
                    return Divide(calculateOperation.InputA, calculateOperation.InputB);

                default:
                    break;
            }
            throw new Exception("Operation Not Found");
        }

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
            return a / (decimal)b;
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