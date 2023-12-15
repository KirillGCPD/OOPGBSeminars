using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Geometry
{
    public class Square : Rectangle
    {
        /// <summary>
        /// Base - базовый конструктор класса прямоугольник
        /// </summary>
        /// <param name="side"></param>
        public Square(double side) : base(side, side) { }
        public double Side
        {
            get => Width;
            set
            {
                Width = value;
                Length = value;
            }
        }
        public override string ToString()
        {
            return $"Квадрат. Сторона = {Width:F2}";
        }
        //Переопределять площадь и периметр есть смысл только для улучшения производительности
        //Для наглядности делать этого в этом классе не будем
    }
}
