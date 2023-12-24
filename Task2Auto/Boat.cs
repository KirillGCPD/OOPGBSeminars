using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Auto
{
    public class Boat : Vehicle, ISwimmable
    {
        public int MaxSpeed { get; private set; }
        public bool IsSailing { get; private set; }
        public Boat(int id, string brand, string model, int year,int maxSpeed) : base(id, brand, model, year)
        {
            MaxSpeed = maxSpeed;
        }

        public override void Accelerate(int speed)
        {
            if (speed > 0)
            {
                if (Speed + speed > MaxSpeed)
                {
                    Speed = MaxSpeed;
                    Console.WriteLine($"Достигнута максимальная скорость: {speed}");
                }
                else
                {
                    Speed += speed;
                    Console.WriteLine($"Скорость увеличена на {speed}. Теперь скорость равна: {Speed}");
                }
            }
            else
            {
                Console.WriteLine($"Скорость можно увеличить только на положительное число");
            }
        }

        public override void Brake()
        {
            Speed = 0;
            Console.WriteLine("Мы остановились");
        }

        public override void DisplayInfo()
        {
            string engine = IsEngineStarted ? "Запущен" : "Не запущен";
            string sailing = IsSailing ? "Лодка плывет" : "Лодка не плывет";
            Console.WriteLine($"Лодка: {this.Id}, {this.Brand}, {this.Brand}, {this.Model}, Год: {this.Year}. Двигатель: {engine}. Скорость: {Speed}. {sailing}");
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

        public void StartSwimming()
        {
            if (!IsEngineStarted)
            {
                Console.WriteLine("Двигатель не запущен");
                return;
            }
          
            IsSailing = true;
            Console.WriteLine("Мы плывем");
        }

        public override void StopEngine()
        {
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

        public void StopSwimming()
        {
            if (!IsSailing)
            {
                Console.WriteLine("Мы не плывем");
                return;
            }

            IsSailing = false;
            Console.WriteLine("Мы остановили лодку");
        }
    }
}
