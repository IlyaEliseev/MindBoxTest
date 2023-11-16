using SquareCalculator.Lib.Abstractions;
using System;

namespace SquareCalculator.Lib.Figures
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Represent triangle.
        /// </summary>
        /// <param name="sideA">First side.</param>
        /// <param name="sideB">Second side.</param>
        /// <param name="sideC">Third side.</param>
        /// <exception cref="ArgumentException">If side triangle less then zero.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentOutOfRangeException("The side of the triangle must not be less than 0.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsRightTriangle = CheckRightTriangle();
        }

        /// <summary>
        /// Side of the triangle
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Side of the triangle
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Side of the triangle
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Checking is right triangle.
        /// </summary>
        /// <returns>True if right triangle and false is not right triangle.</returns>
        public bool IsRightTriangle { get; }

        protected override double CalculateSquare()
        {
            var halfPerimetr = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - SideA) * (halfPerimetr - SideB) * (halfPerimetr - SideC));
        }

        private bool CheckRightTriangle()
        {
            var maxSide = Math.Max(SideA, Math.Max(SideB, SideC));
            var radius = maxSide / 2;
            return 8 * Math.Pow(radius, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
        }
    }
}
