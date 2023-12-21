using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Auto
{
    /// <summary>
    /// Абстрактный класс транспортного средства    
    /// </summary>
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        /// <summary>
        /// Запуск двигателя
        /// </summary>
        public abstract void StartEngine();
        /// <summary>
        /// Остановка двигателя
        /// </summary>
        public abstract void StopEngine();
        /// <summary>
        /// Увеличить скорость
        /// </summary>
        /// <param name="speed">значение скорости</param>
        public abstract void Accelerate(int speed);
        /// <summary>
        /// Остановка *торможение*
        /// </summary>
        public abstract void Brake();
        /// <summary>
        /// Вывод информации о ТС
        /// </summary>
        public abstract void DisplayInfo();
    }
}
