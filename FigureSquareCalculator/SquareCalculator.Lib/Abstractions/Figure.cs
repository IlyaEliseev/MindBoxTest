namespace SquareCalculator.Lib.Abstractions
{
    public abstract class Figure
    {
        private double _square;

        /// <summary>
        /// Get square of the figure
        /// </summary>
        public double Square
        {
            get
            {
                if (_square == default)
                {
                    _square = CalculateSquare();
                }

                return _square; 
            }
        }

        /// <summary>
        /// Calculate square of the figure.
        /// </summary>
        /// <returns>Square of the figure.</returns>
        protected abstract double CalculateSquare();
    }
}