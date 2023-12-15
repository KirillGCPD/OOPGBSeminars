using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Geometry
{
    public class Circle : GeometryBase
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                if (_radius < 0)
                {
                    _radius = 0;
                    Console.WriteLine("Радиус не может быть меньше 0. Мы записали 0");
                }
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * _radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }
        //Для печати
        public override string ToString()
        {
            return $"Круг. Радиус = {_radius}";
        }
    }
}
