using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Figures
{
    public class Triangle : IAreaFinder
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }
        private bool IsRightTriangle { get; }

        public Triangle(double side1, double side2, double side3)
        {
            var checkIsTriangle = CheckExistsTriangle(side1, side2, side3);
            if (side1 < 0.0)
            {
                side1 *= -1;
            }
            if (side2 < 0.0)
            {
                side2 *= -1;
            }
            if (side3 < 0.0)
            {
                side3 *= -1;
            }
            if (!checkIsTriangle)
            {
                throw new ArgumentException();
            }
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            this.IsRightTriangle = IsRightAngle();
        }

        public bool IsRightAngle()
        {
            double hypotenuse = Math.Max(Math.Max(Side1, Side2), Side3);
            double squares = Math.Pow(Side1, 2) + Math.Pow(Side2, 2) + Math.Pow(Side3, 2);
            double maxSideSquare = 2 * Math.Pow(hypotenuse, 2);

            return squares == maxSideSquare;
        }

        public double GetArea()
        {
            double area = new double();
            if (IsRightTriangle)
            {
                double hypotenuse = Math.Max(Math.Max(Side1, Side2), Side3);
                area = ((Side1 * Side2 * Side3) / hypotenuse) / 2;
            }
            else
            {
                double p = (Side1 + Side2 + Side3) / 2;
                area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            }
            return area;
        }

        public bool CheckExistsTriangle(double side1, double side2, double side3)
        {
            if (side1 == 0 || side2 == 0 || side3 == 0)
            {
                return false;
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                return false;
            }

            return true;
        }
    }
}