namespace WhitesharkCheatOverhaul;

public class PublicTransportStationsOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ITransportStationOptions,
    IPollutionOptions,
    IStorageLimitOptions,
    ICargoTransportStationOptions
{
    public string Name { get; set; } = null!;


    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }

    public int StorageLimit { get; set; }
    public int Transports { get; set; }
    public float ComfortFactor { get; set; }

}