namespace AreaCalculator
{
    public class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            #region Проверка на существование треугольника с заданными сторонами

            if (_sideA + _sideB <= _sideC || _sideA + _sideC <= _sideB || _sideB + _sideC <= _sideA)
            {
                throw new Exception("Invalid values for triangle");
            }

            #endregion
        }

        /// <summary>
        /// Метод для вычисления площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double FindArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Round(Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC)), 2);
        }

        /// <summary>
        /// Метод для проверки прямоугольного треугольника
        /// </summary>
        /// <returns>true - прямоугольный, false - непрямоугольный</returns>
        public bool IsRightTriangle()
        {
            double[] sides = { _sideA, _sideB, _sideC };
            sides = sides.OrderByDescending(x => x).ToArray();
            return Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2);
        }
    }
}
