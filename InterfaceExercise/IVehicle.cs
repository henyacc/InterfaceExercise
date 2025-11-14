using System;

namespace InterfaceExercise;

public interface IVehicle
{
    public int EngineSize { get; set; }
    public  string Model { get; set; }
    public string Make { get; set; }
    public int SeatCount { get; set; }
    public string CompanyName { get; set; }
    public string Motto { get; set; }

    public void DisplayDetails();
    //return ($"Car EngineSize: Make: Model: SeatCount: CompanyName: Motto ");


}   
