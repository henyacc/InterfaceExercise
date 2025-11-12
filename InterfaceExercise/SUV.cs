using System;

namespace InterfaceExercise;

public class SUV  : IVehicle, ICompany
{
    public double EngineSize { get; set; } = 4;
    public string Model { get; set; } = "Mustang";
    public string Make { get; set; } = "Ford";
    public int SeatCount { get; set; } = 4;

    public string CompanyName { get; set; } = "Ford";
    public string Motto { get; set; } = "Built Ford Tough";
    public string DisplayDetails { get; set; }

    public void Drive()
    {
            Console.WriteLine($"{GetType().Name} now driving...");
    }

    public void Reverse()
    {
        Console.WriteLine($"{GetType().Name} reversed gears now reversed...");
    }

    public void Park()
    {
        Console.WriteLine($"{GetType().Name} parking...");  
    }
    
}
    
