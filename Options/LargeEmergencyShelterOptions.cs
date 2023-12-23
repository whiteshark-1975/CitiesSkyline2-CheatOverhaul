namespace WhitesharkCheatOverhaul;

public class LargeEmergencyShelterOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int ShelterCapacity { get; set; }
    public int VehicleCapacity { get; set; }
    public int Range { get; set; }
    public int Capacity { get; set; }
    public int Magnitude { get; set; }

}