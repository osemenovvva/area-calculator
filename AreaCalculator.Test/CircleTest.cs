namespace AreaCalculator.Test
{
    public class CircleTest
    {
        private FigureAreaCalculator _figureAreaCalculator;

        [SetUp]
        public void Setup()
        {
            _figureAreaCalculator = new FigureAreaCalculator();
        }

        [Test]
        public void FindCircleArea()
        {
            var expected = Math.Round(Math.PI * Math.Pow(5, 2), 2);
            var actual = _figureAreaCalculator.CalculateArea(new Circle(5));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfRadiusNegativeOrZero()
        {
            var ex = Assert.Throws<Exception>(() => new Circle(0));
            Assert.That(ex.Message, Is.EqualTo("Radius cannot be a negative or zero"));
        }
    }
}
