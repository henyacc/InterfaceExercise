using System;

namespace InterfaceExercise;

public class Trucks : IVehicle , ICompany
{
   private string _displayDetails;
   public double EngineSize { get; set; } = 4;
      public string Model { get; set; } = "Mustang";
      public string Make { get; set; } = "Ford";
      public int SeatCount { get; set; } = 4;

      public string CompanyName { get; set; } = "Ford";
      public string Motto { get; set; } = "Built Ford Tough";

      string IVehicle.DisplayDetails
      {
         get => _displayDetails;
         set => _displayDetails = value;
      }

      public void Drive()
      {
         Console.WriteLine($"{GetType().Name} now driving forward...");
      }

      public void Reverse()
      {
         Console.WriteLine($"{GetType().Name} reversing...");
      }

      public void Park()
      {
         Console.WriteLine($"{GetType().Name} parking...");   
      }

      public void DisplayDetails()
      {
         Console.WriteLine($"{GetType().Name} display details...");
      }
   
}