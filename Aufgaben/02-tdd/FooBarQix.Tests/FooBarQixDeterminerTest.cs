using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
         [Fact]
        public void TestForOne()
        {
            string expected = "1";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.getFoo(1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForThree()
        {
            string expected = "FooFoo";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.getFoo(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForSix()
        {
            string expected = "Foo";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.getFoo(6);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForTwentyOne()
        {
            string expected = "FooQix";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.getFoo(21);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForOneHundredAndFive()
        {
            string expected = "FooBarBarQix";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.getFoo(105);

            Assert.Equal(expected, actual);
        }
    }
}