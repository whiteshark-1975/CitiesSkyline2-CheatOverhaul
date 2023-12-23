namespace WhitesharkCheatOverhaul;

public class FireEngineOptions :
    IBasePrefabOptions,
    IFireEngineOptions
{
    public string Name { get; set; } = null!;

    public int ExtinguishingRate { get; set; }
    public int ExtinguishingSpread { get; set; }
    public int ExtinguishingCapacity { get; set; }
    public int DestroyedClearDuration { get; set; }

}