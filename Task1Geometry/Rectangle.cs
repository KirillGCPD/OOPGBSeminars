using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Geometry
{
    public class Rectangle : GeometryBase
    {
        private double _length;
        private double _width;

        public double Width {
            get => _width;
            set 
            { 
                _width = value;
                if (_width < 0)
                {
                    Console.WriteLine("Ширина не может быть отрицательной"); 
                    _width = 0;
                };
            }
        }
        public double Length
        {
            get => _length;
            set
            {
                _length = value;
                if (_length < 0)
                {
                    Console.WriteLine("Длина не может быть отрицательной");
                    _length = 0;
                };
            }
        }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Width*Length;
        }
        public override double CalculatePerimeter()
        {
            return (Width+Length)*2;
        }
        public override string ToString()
        {
            return $"Прямоугольник. Длина: {Length:F2}. Ширина: {Width:F2}.";
        }
    }
}
