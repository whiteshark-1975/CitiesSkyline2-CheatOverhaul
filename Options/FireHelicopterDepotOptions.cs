namespace WhitesharkCheatOverhaul;

public class FireHelicopterDepotOptions :
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
    public int DisasterResponseCapacity { get; set; }

}