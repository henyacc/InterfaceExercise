using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program 
    {
        static void Main(string[] args)
        {
            var cars = new Cars();
            var trucks = new Trucks();
            var suv = new SUV();

            var vehicles = new List<IVehicle>();
            vehicles.Add(cars);
            vehicles.Add(trucks);
            vehicles.Add(suv);
            
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails();
                //Console.WriteLine($"This vehicle has{vehicle.EngineSize: Make: Model: SeatCount: CompanyName: Motto}");
            }

            Console.ReadLine();









        }
    }
}
