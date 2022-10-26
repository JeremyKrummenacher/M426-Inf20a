using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplicateThreeTimesSixIsEighteen()
        {
            //Given
            int a = 3;
            int b = 6;
            int expected = 18;
            Calculator calculator = new Calculator();

            //when
            int actual = calculator.Multiply(a, b);

            //then

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideEightTroughTwo()
        {
            // Given
            double a = 8;
            double b = 2;
            double expected = 4;
            Calculator calculator = new Calculator();

            // When
            double actual = calculator.Divide(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideEightTroughZero()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => Assert.Equal(0, calculator.Divide(8, 0)));
        }
    }
}
