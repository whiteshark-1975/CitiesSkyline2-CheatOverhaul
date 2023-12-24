namespace WhitesharkCheatOverhaul;

public class PostofficeOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IServiceCoverageOptions,
    IPollutionOptions,
    IPostFacilityOptions
{
    public string Name { get; set; } = null!;
    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int TelecomNeed { get; set; }
    public float ServiceCoverageRange { get; set; }
    public float ServiceCoverageCapacity { get; set; }
    public float ServiceCoverageMagnitude { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int MailStorageCapacity { get; set; }
    public int MailboxCapacity { get; set; }
    public int PostVanCapacity { get; set; }
    public int PostTrucksCapacity { get; set; }
    public int SortingRate { get; set; }

}