using AreaCalculator;

namespace SquareCounter.Test
{
    public class Tests
    {
        private FigureAreaCalculator _figureAreaCalculator;

        [SetUp]
        public void Setup()
        {
            _figureAreaCalculator = new FigureAreaCalculator();
        }

        [Test]
        public void FindTriangleArea()
        {
            var actual = _figureAreaCalculator.CalculateArea(new Triangle(3, 4, 5));
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void CheckCorrectValuesForTriangle()
        {
            var ex = Assert.Throws<Exception>(() => new Triangle(1, 1, 10));
            Assert.That(ex.Message, Is.EqualTo("Invalid values for triangle"));
        }

        [Test]
        public void CheckRightTriangle()
        {
            Triangle rightTriangleUnderTests = new Triangle(3, 4, 5);
            var actual = rightTriangleUnderTests.IsRightTriangle();
            Assert.AreEqual(true, actual);
        }

    }
}