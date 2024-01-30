using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Calculator
{
    /// <summary>
    /// Интерфейс для объектов, которые можно складывать, вычитать и т.д.
    /// </summary>
    public interface ICalculable
    {
        ICalculable Sum(ICalculable number);
        ICalculable Minus(ICalculable number);
        ICalculable Divide(ICalculable number);
        ICalculable Multiplicate(ICalculable number);

        ComplexNumber Value();
    }
}
