using System;
using System.ComponentModel.Design;

namespace InterfaceExercise
{
    public class Cars : IVehicle , ICompany
    {
        public int EngineSize { get; set; } = 2;
        public string Model { get; set; } = "";
        public string Make { get; set; } = "3 Series";
        public int SeatCount { get; set; } = 4;

        public string CompanyName { get; set; } = "the BMW Group";
        public string Motto { get; set; } = "The Ultimate Driving Machine";
        
        public void DisplayDetails()
        {
            Console.WriteLine($"EngineSize: {EngineSize} Make: {Make} Model: {Model} SeatCount: {SeatCount} CompanyName: {CompanyName} Motto: {Motto}");
        }
        
    }
}

