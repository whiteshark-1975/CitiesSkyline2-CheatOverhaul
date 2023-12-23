namespace WhitesharkCheatOverhaul;

public class LargeEmergencyShelterOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IServiceCoverageOptions,
    IEmergencyShelterOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int ServiceCoverageRange { get; set; }
    public int ServiceCoverageCapacity { get; set; }
    public int ServiceCoverageMagnitude { get; set; }
    public int ShelterCapacity { get; set; }
    public int VehicleCapacity { get; set; }
}