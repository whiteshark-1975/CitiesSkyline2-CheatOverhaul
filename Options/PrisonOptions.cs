namespace WhitesharkCheatOverhaul;

public class PrisonOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    IPrisonOptions,
    ILocalCrimeAccumulation
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
    public int PrisonVanCapacity { get; set; }
    public int PrisonerCapacity { get; set; }
    public float LocalCrimeAccumulation { get; set; }
    public float LocalCrimeAccumulationRadius { get; set; }
}