using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Geometry
{
    public class GeometryBase
    {
        /// <summary>
        /// Вычислить площадь. Метод виртуальный чтоб была возможность переопределить поведение
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public virtual double CalculateArea()
        {
            return 0;
        }
        /// <summary>
        /// Вычислить периметр. Виртуальный метод.
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }
}
