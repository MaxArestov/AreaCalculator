using AreaCalculator.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace AreaCalculator.Figures
{
    public class Circle : IAreaFinder
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0.0)
            {
                radius *= -1;
            }
            this.Radius = radius;
        }

        public double GetArea()
        {
            double result = Math.PI * Math.Pow(Radius, 2.0);
            return result;
        }
    }
}