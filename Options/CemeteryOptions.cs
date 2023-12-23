namespace WhitesharkCheatOverhaul;

public class CemeteryOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IDeathcareFacilityOptions,
    ILeisureProviderOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }

    public int HearseCapacity { get; set; }
    public int StorageCapacity { get; set; }
    public int ProcessingRate { get; set; }
    public int LeisureEfficiency { get; set; }

}