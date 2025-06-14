using Xunit;
using CalculatorProj;
using System;
using CalculatorProj;

namespace CalculatorProj.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 3, "+", 5)]
        [InlineData(5, 2, "-", 3)]
        [InlineData(4, 3, "*", 12)]
        [InlineData(10, 2, "/", 5)]
        public void TestBasicOperations(double a, double b, string op, double expected)
        {
            double result = CalculatorLogic.Calculate(a, b, op);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorLogic.Calculate(5, 0, "/"));
        }
    }
}
