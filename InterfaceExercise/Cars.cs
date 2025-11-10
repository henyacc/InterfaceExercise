using System;
using System.ComponentModel.Design;

namespace InterfaceExercise;

public class Cars
{
    public Cars()
    {
    }
    public double EngineSize { get; set; } = 4;
    public string Model { get; set; } = "Mustang";
    public string Make { get; set; } = "Ford";
    public int SeatCount { get; set; } = 4;
    
    public string CompanyName { get; set; } = "Ford";
    public string Motto { get; set; } = "Built Ford Tough";
    public bool HasChangedGears { get; set; }
    
    public void Drive()
    {
      Console.WriteLine($"{GetType().Name} now driving forward...");  
    }
    
    
    public void Reverse()
    {
        if(HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} reversed gears!");
            HasChangedGears = false;
        }
        else
        {
           Console.WriteLine($"Can't reverse until we change gears!"); 
        }
    }

    public void Park()
    {
        Console.WriteLine($"{GetType().Name} parking...");
    }

    public bool ChangedGears(bool hasChangedGears)
    {
        HasChangedGears = hasChangedGears;
        HasChangedGears = false;
        return hasChangedGears;
    }
}  