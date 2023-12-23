namespace WhitesharkCheatOverhaul;

public class PoliceStationOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    IPoliceStationOptions,
    IServiceCoverageOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int PatrolCarCapacity { get; set; }
    public int PoliceHelicopterCapacity { get; set; }
    public int JailCapacity { get; set; }
    public int ServiceCoverageRange { get; set; }
    public int ServiceCoverageCapacity { get; set; }
    public int ServiceCoverageMagnitude { get; set; }
    
    
}