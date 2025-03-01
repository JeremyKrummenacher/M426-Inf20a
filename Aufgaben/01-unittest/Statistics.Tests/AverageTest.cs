using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 1, 3 };
            double expected = 2;
            Average average = new Average();

            double actual = average.Mean(numbers);  

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 1, 3, 4, 6, 8 };
            double expected = 4.4;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int>{};

            Average average = new Average();
            Assert.Throws<ArgumentException>(() => Assert.Equal(0, average.Mean(numbers)));
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int>{};

            Average average = new Average();
            Assert.Throws<ArgumentException>(() => Assert.Equal(0, average.Mean(numbers)));
        }
    }
}
