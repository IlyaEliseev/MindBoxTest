using SquareCalculator.Lib.Figures;
using System;
using Xunit;

namespace FigureSquareCalculator.Tests
{
    public class CircleSquareCalculatorTests
    {
        [Fact]
        public void Calculate_square_of_the_circle()
        {
            // arrange
            var radius = 10;
            var expectedSquare = Math.PI * radius * radius;
            var sut = new Circle(radius);

            // act
            var sutResult = sut.Square;

            // assert
            Assert.Equal(expectedSquare, sutResult);
        }

        [Fact]
        public void Circle_square_when_radius_less_then_zero()
        {
            // assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }
    }
}