namespace WhitesharkCheatOverhaul;

public class WelfareOfficeOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IServiceCoverageOptions,
    IPollutionOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int ServiceCoverageRange { get; set; }
    public int ServiceCoverageCapacity { get; set; }
    public int ServiceCoverageMagnitude { get; set; }
    


}