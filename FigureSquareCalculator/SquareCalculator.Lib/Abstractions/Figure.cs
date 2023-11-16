using System.IO;

namespace SquareCalculator.Lib.Abstractions
{
    public abstract class Figure
    {
        /// <summary>
        /// Calculate square of the figure.
        /// </summary>
        /// <returns>Square of the figure.</returns>
        public abstract double CalculateSquare();
    }
}