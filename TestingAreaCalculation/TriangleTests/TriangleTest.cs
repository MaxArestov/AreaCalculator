namespace TestingAreaCalculation.TriangleTests
{
    public class TriangleTest
    {
        [Fact]
        public void GetArea_ShouldReturnCorrectValue_ForPositiveSides()
        {
            double side1 = 5;
            double side2 = 4;
            double side3 = 3;
            double expectedArea = 6;

            var triangle = new Triangle(side1, side2, side3);

            double actualArea = triangle.GetArea();

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightAngled_ShouldReturnTrue_ForRightAngledTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            var triangle = new Triangle(side1, side2, side3);

            bool isRightAngled = triangle.IsRightAngle();

            Assert.True(isRightAngled);
        }

        [Fact]
        public void GetArea_ShouldThrowException_ForNonExistingTriangle()
        {
            double side1 = 5;
            double side2 = 10;
            double side3 = 20;

            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void IsRightAngled_ShouldReturnFalse_ForNonRightAngledTriangle()
        {
            double side1 = 5;
            double side2 = 6;
            double side3 = 7;

            var triangle = new Triangle(side1, side2, side3);

            bool isRightAngled = triangle.IsRightAngle();

            Assert.False(isRightAngled);
        }
    }
}
