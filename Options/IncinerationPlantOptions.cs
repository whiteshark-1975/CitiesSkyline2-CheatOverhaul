namespace WhitesharkCheatOverhaul;

public class IncinerationPlantOptions :
    IServiceConsumptionOptions,
    IPollutionOptions,
    IGarbageFacilityOption,
    IPowerPlantOptions,
    IGarbagePoweredOptions,
    ICityIndustrialGroundPollution
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int GarbageCapacity { get; set; }
    public int GarbageVehicleCapacity { get; set; }
    public int GarbageTransportCapacity { get; set; }
    public int GarbageProcessingspeed { get; set; }
    public int ElectricityProduction { get; set; }
    public float ProductionPerUnit { get; set; }
    public int ProductionCapacity { get; set; }
    public float CityIndustrialGroundPollution { get; set; }
    
}