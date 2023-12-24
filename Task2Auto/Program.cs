namespace Task2Auto
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(1,"Toyota","Land Crouser",2022,90);
            var aircraft = new Aircraft(2, "Boing", "747", 1995, 4000);
            var boat = new Boat(3, "Solar", "JetSpeed", 1999, 50);

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(car);
            vehicles.Add(aircraft);
            vehicles.Add(boat);

            car.Refuel(50);
            Console.WriteLine("");
          
            //Полиморфизм - объекты разные, но запакованы в один абстрактный класс
            foreach (var vehicle in vehicles)
            {
                vehicle.StartEngine();
                vehicle.Accelerate(100);
                vehicle.DisplayInfo();
                Console.WriteLine("");
            }
            Console.WriteLine("");
            IFlyable flyable = aircraft;
            aircraft.Accelerate(100);
            flyable.TakeOff();
            flyable.Land();
            Console.WriteLine("");
            ISwimmable swimmable = boat;
            swimmable.StartSwimming();
            swimmable.StopSwimming();
            Console.WriteLine("");
            foreach (var vehicle in vehicles)
            {
                vehicle.StopEngine();
                vehicle.DisplayInfo();
                Console.WriteLine("");
            }

        }
    }
}
