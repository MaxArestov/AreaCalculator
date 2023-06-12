namespace TestingAreaCalculation.CircleTests
{
    public class CircleTest
    {
        [Fact]
        public void GetArea_ReturnsCorrectArea_ForPositiveRadius()
        {
            double radius = 5.0;
            double expectedArea = 78.54;

            Circle circle = new Circle(radius);

            double actualArea = circle.GetArea();

            Assert.Equal(expectedArea, actualArea, precision: 2);
        }

        [Fact]
        public void GetArea_ReturnsCorrectArea_ForZeroRadius()
        {
            double radius = 0.0;
            double expectedArea = 0.0;

            Circle circle = new Circle(radius);

            double actualArea = circle.GetArea();

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void Constructor_ChangesNegativeRadiusToPositive_ForNegativeRadius()
        {
            double radius = -5.0;
            double expectedRadius = 5.0;

            Circle circle = new Circle(radius);
            double actualRadius = circle.Radius;

            Assert.Equal(expectedRadius, actualRadius);
        }
    }
}
