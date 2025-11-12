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

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Reverse();
                vehicle.Park();
              
            }
        
            

       

           

          

        }
    }
}
