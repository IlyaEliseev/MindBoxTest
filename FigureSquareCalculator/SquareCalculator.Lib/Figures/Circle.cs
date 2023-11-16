using SquareCalculator.Lib.Abstractions;
using System;

namespace SquareCalculator.Lib.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Represent circle.
        /// </summary>
        /// <param name="radius">Radius circle.</param>
        /// <exception cref="ArgumentException">If radius circle less then zero.</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("The radius of the triangle must not be less than 0.");
            }

            Radius = radius;
        }

        /// <summary>
        /// Radius of the circle.
        /// </summary>
        public double Radius { get; }

        protected override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
