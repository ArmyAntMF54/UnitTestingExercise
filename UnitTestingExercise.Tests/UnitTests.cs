using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5,10,-5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();

            //Act
            var actual = test1.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5,4,20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var tested = new UnitTestMethods();

            //Act
            var actual = tested.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6,2,3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var tester2 = new UnitTestMethods();

            //Act
            var actual = tester2.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var expected = "M";

            //Act


            //Assert
            Assert.Equal(expected,actual);

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var expected = "Who";
            //Act

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
