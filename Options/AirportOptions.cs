namespace WhitesharkCheatOverhaul;

public class AirportOptions : 
    IBasePrefabOptions, 
    IServiceConsumptionOptions,
    IStorageLimitOptions,
    ICargoTransportStationOptions,
    ITransportStationOptions,
    ICityAttractiveness,
    ICityOfficeEfficiency,
    ICityUniversityInterest,
    ICityOfficeSoftwareDemand

{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int StorageLimit { get; set; }
    public int Transports { get; set; }
    public float ComfortFactor { get; set; }
    public float CityAttractiveness { get; set; }
    public float CityOfficeEfficiency { get; set; }
    public float CityUniversityInterest { get; set; }
    public float CityOfficeSoftwareDemand { get; set; }

}