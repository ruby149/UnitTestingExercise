using System;
using System.ComponentModel;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(4,5,6,15)]
        [InlineData(300,300,200, 800)]
        [InlineData(20 ,50,60,130)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();
            //Act
            var actual = calculator.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]
        [InlineData(10, 2, 8)]
        [InlineData(15,3,12)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var substracting = new UnitTestMethods();
            //Act
            var actual = substracting.Subtract( minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,2,10)]
        [InlineData(6, 2, 12)]
        [InlineData(3,5,15)]

        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiplication = new UnitTestMethods();
            //Act
            var actual = multiplication.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(300, 3, 100)]
        [InlineData(100,20,5)]

        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var division = new UnitTestMethods();
            //Act
            var actual = division.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
