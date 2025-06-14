using System;

namespace CalculatorProj
{
    public static class CalculatorLogic
    {
        public static double Calculate(double num1, double num2, string op)
        {
            return op switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num2 == 0 ? throw new DivideByZeroException() : num1 / num2,
                _ => throw new ArgumentException("Invalid operator")
            };
        }
    }
}
