using SquareCalculator.Lib.Figures;
using System;
using Xunit;

namespace FigureSquareCalculator.Tests
{
    public class TriangleCalculatorSquareTests
    {
        [Fact]
        public void Calculate_square_of_the_triangle()
        {
            // arrange
            var sideA = 5;
            var sideB = 7;
            var sideC = 8;
            var sut = new Triangle(sideA, sideB, sideC);
            var halfPerimetr = (sideA + sideB + sideC) / 2;
            var expectedSquare = Math.Sqrt(halfPerimetr * (halfPerimetr - sideA) * (halfPerimetr - sideB) * (halfPerimetr - sideC));

            // act
            var sutResult = sut.Square;

            // assert
            Assert.Equal(expectedSquare, sutResult);
        }

        [Fact]
        public void Triangle_when_one_of_side_less_then_zero()
        {
            // assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 4, 6));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, -1, 6));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 4, -1));
        }

        [Fact]
        public void Triangle_is_a_right_triangle()
        {
            // arrange
            var sideA = 6;
            var sideB = 8;
            var sideC = Math.Sqrt(sideA * sideA + sideB * sideB);
            var sut = new Triangle(sideA, sideB, sideC);
            var expected = true;

            // act
            var sutResult = sut.IsRightTriangle;

            // assert
            Assert.Equal(expected, sutResult);
        }

        [Fact]
        public void Triangle_is_not_a_right_triangle()
        {
            // arrange
            var sideA = 6;
            var sideB = 8;
            var sideC = Math.Sqrt(sideA * sideA + sideB * sideB) + 2;
            var sut = new Triangle(sideA, sideB, sideC);
            var expectedResult = false;

            // act
            var sutResult = sut.IsRightTriangle;

            // assert
            Assert.Equal(expectedResult, sutResult);
        }
    }
}
