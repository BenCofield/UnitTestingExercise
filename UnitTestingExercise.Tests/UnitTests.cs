using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, -7, -9, -13)]
        [InlineData(4, 5, -6, 3)]
        [InlineData(-3, -5, -12, -20)]
        [InlineData(-2, 30, -13, 15)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 3, 4)]//Add test data <-------
        [InlineData(30, 73, -43)]
        [InlineData(-12, -4, -8)]
        [InlineData(-4, 12, -16)]
        [InlineData(-5, -20, 15)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, -4, -16)]//Add test data <-------
        [InlineData(-6, 3, -18)]
        [InlineData(-7, -6, 42)]
        [InlineData(-8, -8, 64)]
        [InlineData(13, 13, 169)]
        [InlineData(23423, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 7, 7)]//Add test data <-------
        [InlineData(78, 8, 9)]
        [InlineData(17, -3, -5)]
        [InlineData(0, 24, 0)]
        [InlineData(-34, 6, -5)]
        [InlineData(-12, -3, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
