using System.Data;

namespace AreaCalculator
{
    public class FigureAreaCalculator
    {
        public FigureAreaCalculator() { }

        /// <summary>
        /// Метод для подсчета площади фигуры в зависимости от ее типа
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>Площадь фигуры</returns>
        public double CalculateArea(IFigure figure)
        {
            return figure.FindArea();
        }
    }
}
