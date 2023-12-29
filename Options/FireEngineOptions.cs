namespace WhitesharkCheatOverhaul;

public class FireEngineOptions :
    IBasePrefabOptions,
    IFireEngineOptions
{
    public string Name { get; set; } = null!;

    public float ExtinguishingRate { get; set; }
    public float ExtinguishingSpread { get; set; }
    public float ExtinguishingCapacity { get; set; }
    public float DestroyedClearDuration { get; set; }

}