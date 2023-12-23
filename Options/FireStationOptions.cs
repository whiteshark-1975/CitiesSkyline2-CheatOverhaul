namespace WhitesharkCheatOverhaul;

public class FireStationOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int Noisepollution { get; set; }
    public int FireEngineCapacity { get; set; }
    public int FireHelicopterCapacity { get; set; }
    public int VehicleEfficiency { get; set; }
    public int DisasterResponseCapacity { get; set;}
    public int Range { get; set; }
    public int Capacity { get; set; }
    public int Magnitude { get; set; }

}