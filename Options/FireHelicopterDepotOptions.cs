namespace WhitesharkCheatOverhaul;

public class FireHelicopterDepotOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    IFireStationOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int TelecomNeed { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int FireEngineCapacity { get; set; }
    public int FireHelicopterCapacity { get; set; }
    public float VehicleEfficiency { get; set; }
    public int DisasterResponseCapacity { get; set; }

}