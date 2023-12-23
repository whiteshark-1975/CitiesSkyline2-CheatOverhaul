namespace WhitesharkCheatOverhaul;

public class PoliceStationOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int PatrolCarCapacity { get; set; }
    public int PoliceHelicopterCapacity { get; set; }
    public int JailCapacity { get; set; }
    public int Range { get; set; }
    public int Capacity { get; set; }
    public int Magnitude { get; set; }
    public int Noisepollution { get; set; }
    
}