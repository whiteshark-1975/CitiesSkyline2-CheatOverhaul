namespace WhitesharkCheatOverhaul;

public class PowerplantOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    IPowerPlantOptions,
    IStorageLimitOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int AirPollution { get; set; }
    public int GroundPollution { get; set; }
    public int NoisePollution { get; set; }
    public int ElectricityProduction { get; set; }
    public int StorageLimit { get; set; }
}