using Calculator;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldDoAddition()
        {
            double result = MyCalculator.DoOperation(1, 2, "a");
            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldDoSubtract()
        {
            double result = MyCalculator.DoOperation(5, 4, "s");
            Assert.Equal(1, result);
        }

        [Fact]
        public void ShouldDoMultiply()
        {
            double result = MyCalculator.DoOperation(6, 7, "m");
            Assert.Equal(42, result);
        }

        [Fact]
        public void ShouldDoDivide()
        {
            double result = MyCalculator.DoOperation(8, 2, "d");
            Assert.Equal(4, result);
        }

        [Fact]
        public void ShouldDoNotDivide()
        {
            double result = MyCalculator.DoOperation(4, 0, "d");
            Assert.Equal(double.NaN, result);
        }

        [Fact]
        public void ShouldReturnIncorrectOptionEntry()
        {
            double result = MyCalculator.DoOperation(5, 4, " ");
            Assert.Equal(Double.NaN, result);
        }
    }
}