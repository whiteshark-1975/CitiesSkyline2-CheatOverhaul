namespace WhitesharkCheatOverhaul;

public class SpaceCenterOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ITransportDepotOptions,
    IAttractionOptions,
    ICityUniversityInterest,
    ICityOfficeSoftwareDemand,
    ICityIndustrialElectronicDemand,
    ICityAttractiveness,
    ILeisureProviderOptions

{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public int VehicleCapacity { get; set; }
    public float MaintenanceDuration { get; set; }
    public float ProductionDuration { get; set; }
    public int Attractiveness { get; set; }
    public float CityAttractiveness { get; set; }
    public float CityIndustrialElectronicDemand { get; set; }
    public float CityUniversityInterest { get; set; }
    public float CityOfficeSoftwareDemand { get; set; }
    public int LeisureEfficiency { get; set; }

}