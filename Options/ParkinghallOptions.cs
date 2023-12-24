namespace WhitesharkCheatOverhaul;

public class ParkinghallOptions :
    IBasePrefabOptions,
    IParkingFacilityOptions,
    IServiceConsumptionOptions,
    IPollutionOptions
{
    public string Name { get; set; } = null!;

    public int GarageCapacity { get; set; }
    public float Comfortfactor { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int TelecomNeed { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int Upkeep { get; set; }

}