namespace WhitesharkCheatOverhaul;

public class CityparkOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IServiceCoverageOptions,
    IAttractionOptions,
    ILeisureProviderOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int ServiceCoverageRange { get; set; }
    public int ServiceCoverageCapacity { get; set; }
    public int ServiceCoverageMagnitude { get; set; }
    public int Attractiveness { get; set; }
    public int LeisureEfficiency { get; set; }
    
    


}