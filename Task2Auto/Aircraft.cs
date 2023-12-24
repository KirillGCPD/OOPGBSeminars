using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Auto
{
    internal class Aircraft : Vehicle, IFlyable
    {

        private int _maxAltitude;

        public Aircraft(int id, string brand, string model, int year, int maxAltitude) : base(id, brand, model, year)
        {
            _maxAltitude = maxAltitude;
        }

        public int MaxAltitude
        {
            get { return _maxAltitude; }
        }
        /// <summary>
        /// Флаг полета. Тестирую автосвойства - геттер публичный, сеттер закрыт
        /// </summary>
        public bool IsFlying { get; private set; }
        public override void Accelerate(int speed)
        {
            if (speed > 0)
            {
                Speed += speed;
                Console.WriteLine($"Скорость увеличена на {speed}. Теперь скорость равна: {Speed}");
            }
            else
            {
                Console.WriteLine($"Скорость можно увеличить только на положительное число");
            }
        }

        public override void Brake()
        {
            if (Speed > 0 &&!IsFlying)
            {
                Speed = 0;
                Console.WriteLine("Самолет остановлен");
            }
            if (IsFlying)
            {
                Console.WriteLine("Нельзя тормозить - мы летим");
            }
            
        }

        public override void DisplayInfo()
        {
            string isFlying = IsFlying ? "В полете" : "На земле";
            Console.WriteLine($"Самолет: {this.Id}, {this.Brand}, {this.Brand}, {this.Model}, Год: {this.Year}. Состояние: {isFlying}. Скорость: {Speed}");
        }

        public void Land()
        {
            if (IsFlying)
            {
                Console.WriteLine("Заходим на посадку");
                IsFlying = false;
            }
            else { 
                Console.WriteLine("Самолет уже на земле");
            }
        }

        public override void StartEngine()
        {
            
            if (IsEngineStarted)
            {
                Console.WriteLine("Двигатель уже запущен");
            }
            else
            {
                Console.WriteLine("Двигатель запущен");
                IsEngineStarted = true;
            }
        }

        public override void StopEngine()
        {
            if (IsFlying)
            {
                Console.WriteLine("Сначала посадите самолет");
                return;
            }
            if (IsEngineStarted)
            {
                Console.WriteLine("Двигатель остановлен");
                IsEngineStarted = false;
            }
            else
            {
                Console.WriteLine("Двигатель не запущен");

            }
        }

        public void TakeOff()
        {
            if (IsFlying)
            {
                Console.WriteLine("Мы уже в полете");
                return;
            }
            if (!IsEngineStarted)
            {
                Console.WriteLine("Двигатель не запущен");
                return;
            }
            if (Speed<150)
            {
                Console.WriteLine("Не хватает скорости");
                return;
            }
            IsFlying = true;
            Console.WriteLine("Мы взлетели");
        }
    }
}
