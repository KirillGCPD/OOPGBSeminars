using System.Drawing;

namespace Task1Geometry
{

    /* Создайте иерархию классов для представления различных геометрических фигур. 
     * Каждая фигура должна иметь метод для вычисления площади (calculateArea) и метод для вычисления периметра (calculatePerimeter). 
     * Реализуйте следующие фигуры:
        Круг (Circle):
        Свойства: радиус (radius).
        Методы: calculateArea и calculatePerimeter для вычисления площади и периметра соответственно.

        Прямоугольник (Rectangle):
        Свойства: длина (length) и ширина (width).
        Методы: calculateArea и calculatePerimeter для вычисления площади и периметра соответственно.

        Квадрат (Square), который является подклассом прямоугольника:
        Свойства: сторона (side).
        Методы: calculateArea и calculatePerimeter для вычисления площади и периметра соответственно.
        И переопределите методы родительского класса, чтобы они соответствовали квадрату.

        */

    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometryBase circle = new Circle(5); //круг со стороной 5
            //Использую базовый класс, чтоб показать, как работает полиморфизм
            Console.WriteLine(circle);
            Console.WriteLine($"Периметр: {circle.CalculatePerimeter():F2}; Площадь: {circle.CalculateArea():F2}");

            Rectangle rectangle = new Rectangle(2, 5);
            Console.WriteLine(rectangle);
            double p=rectangle.CalculatePerimeter();
            double a=rectangle.CalculateArea();
            Console.WriteLine($"Периметр: {p:F2}; Площадь: {a:F2}");

            Square square = new Square(5);
            Console.WriteLine(square);
            p = square.CalculatePerimeter();
            a = square.CalculateArea();
            Console.WriteLine($"Периметр: {p:F2}; Площадь: {a:F2}");
        }
    }
}
