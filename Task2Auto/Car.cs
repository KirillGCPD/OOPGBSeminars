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

        /// <summary>
        /// Вместимость бака. 
        /// </summary>
        public int FuelCapacity
        {
            get => _fuelCapacity; //Реализован толькко геттер для инкапсуляции
        }
        public int CurrentFuelLevel
        {
            get => _currentFuelLevel; //Реализован толькко геттер для инкапсуляции 
        }
        public override void Accelerate(int speed)
        {
            throw new NotImplementedException();
        }

        public override void Brake()
        {
            throw new NotImplementedException();
        }

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }

        public override void StartEngine()
        {
            throw new NotImplementedException();
        }

        public override void StopEngine()
        {
            throw new NotImplementedException();
        }
        
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
