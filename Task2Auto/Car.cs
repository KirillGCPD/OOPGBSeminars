using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Auto
{
    public class Car : Vehicle
    {

        private int _currentFuelLevel;
        private int _fuelCapacity;

        public Car(int id, string brand, string model, int year, int fuelCapcity) : base(id, brand, model, year)
        {
            _fuelCapacity = fuelCapcity;
        }

        /// <summary>
        /// Вместимость бака. 
        /// </summary>
        public int FuelCapacity
        {
            get => _fuelCapacity; //Реализован только геттер для инкапсуляции
        }
        public int CurrentFuelLevel
        {
            get => _currentFuelLevel; //Реализован только геттер для инкапсуляции 
        }
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
            if (Speed > 0)
            {
                Speed = 0;
                Console.WriteLine("Машина остановлена");
            }
        }

        public override void DisplayInfo()
        {
            string engine = IsEngineStarted ? "Запущен" : "Не запущен";
            Console.WriteLine($"Автомобиль: {this.Id}, {this.Brand}, {this.Brand}, {this.Model}, Год: {this.Year}. Двигатель: {engine}. Количество топлива: {CurrentFuelLevel}. Скорость: {Speed}");
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
            if (IsEngineStarted)
            {
                Console.WriteLine("Двигатель остановлен");
                IsEngineStarted= false;
            }
            else
            {
                Console.WriteLine("Двигатель не запущен");
               
            }
        }
        
        /// <summary>
        /// Заправить бак
        /// </summary>
        /// <param name="liters">Количество литров</param>
        public void Refuel(int liters)
        {
            if (liters < 0)
            {
                Console.WriteLine("Нельзя залить в бак отрицательное количество топлива");
                return;
            }
            if (_currentFuelLevel + liters > _fuelCapacity)
            {
                _currentFuelLevel = _fuelCapacity;
                Console.WriteLine($"Бак полностью заполнен."); ; ;
            }
            else
            {
                _currentFuelLevel += liters;
                Console.WriteLine($"Заливаем в бак {liters} литров.");
            }
            Console.WriteLine($"В баке {_currentFuelLevel} литров.");
        }
    }
}
