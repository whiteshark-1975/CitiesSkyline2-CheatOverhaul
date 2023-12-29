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
    public float TelecomNeed { get; set; }
    public float ServiceCoverageRange { get; set; }
    public float ServiceCoverageCapacity { get; set; }
    public float ServiceCoverageMagnitude { get; set; }
    public int Attractiveness { get; set; }
    public int LeisureEfficiency { get; set; }
    
    


}