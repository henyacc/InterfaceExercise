using System;

namespace InterfaceExercise;

public class SUV  : IVehicle, ICompany
{
    public int EngineSize { get; set; } = 4;
    public string Model { get; set; } = "Wrangler";
    public string Make { get; set; } = "Jeep";
    public int SeatCount { get; set; } = 4;

    public string CompanyName { get; set; } = "Stellantis";
    public string Motto { get; set; } = "Powered by our Diversity";

    public void DisplayDetails()
    {
        Console.WriteLine($"EngineSize: {EngineSize} Make: {Make} Model: {Model} SeatCount: {SeatCount} CompanyName: {CompanyName} Motto: {Motto}");
    }
    

    

    
    
    
}
    
