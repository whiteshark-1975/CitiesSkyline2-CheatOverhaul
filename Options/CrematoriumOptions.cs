namespace WhitesharkCheatOverhaul;

public class CrematoriumOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    IDeathcareFacilityOptions
    

{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int HearseCapacity { get; set; }
    public int StorageCapacity { get; set; }
    public float ProcessingRate { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }

}