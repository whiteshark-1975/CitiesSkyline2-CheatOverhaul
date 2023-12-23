namespace WhitesharkCheatOverhaul;

public class WaterpumpOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    IWaterPumpingStationOptions


{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int ElectricityConsumption { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int PumpCapacity { get; set; }
    public float Purification  { get; set; }

}
