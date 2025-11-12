namespace InterfaceExercise;

public interface IVehicle
{
    public double EngineSize { get; set; }
    public  string Model { get; set; }
    public string Make { get; set; }
    public int SeatCount { get; set; }
    public string CompanyName { get; set; }
    public string Motto { get; set; }
    public string DisplayDetails{ get; set; }

    public void Drive();
    public void Reverse();
    public void Park();
    
}