using System;

namespace InterfaceExercise;

public class Trucks : IVehicle , ICompany
{
      public int EngineSize { get; set; } = 4;
      public string Model { get; set; } = "Yukon";
      public string Make { get; set; } = "GMC";
      public int SeatCount { get; set; } = 4;

      public string CompanyName { get; set; } = "General Motors";
      public string Motto { get; set; } = "Everybody in";

      public void DisplayDetails()
      {
          Console.WriteLine($"EngineSize: {EngineSize} Make: {Make} Model: {Model} SeatCount: {SeatCount} CompanyName: {CompanyName} Motto: {Motto}");
      }

      
         
   
}