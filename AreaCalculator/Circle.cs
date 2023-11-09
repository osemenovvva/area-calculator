namespace AreaCalculator
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;

            #region Проверка, не является ли радиус 0 или отрицательным значением

            if (radius <= 0)
            {
                throw new Exception("Radius cannot be a negative or zero");
            }

            #endregion
        }

        /// <summary>
        /// Метод для вычисления площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double FindArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }

    }
}