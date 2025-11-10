using System;

namespace InterfaceExercise;

public class SUV
{

    public SUV()
    {
    }

    public double EngineSize { get; set; } = 4;
    public string Model { get; set; } = "Mustang";
    public string Make { get; set; } = "Ford";
    public int SeatCount { get; set; } = 4;

    public string CompanyName { get; set; } = "Ford";
    public string Motto { get; set; } = "Built Ford Tough";
    public bool HasChangedGears { get; set; }
    public bool HasFourWheelDrive { get; set; }

    public void Drive()
    {
        if (HasFourWheelDrive)
        {
            Console.WriteLine($"Four wheeldrive{GetType().Name} now driving forward...");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} now driving backward...");
        }
    
    }

    public void Reverse()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} reversed gears now reversed...");
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine($"Can't reverse until we change gears");
        }
    }

    public void Park()
    {
        Console.WriteLine($"{GetType().Name} parking...");  
    }

    public bool ChangedGears(bool hasChangedGears)
    {
        HasChangedGears = hasChangedGears;
        return hasChangedGears;
        HasChangedGears = false;
    }
}
    
