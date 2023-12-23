namespace WhitesharkCheatOverhaul;

public class FireEngineOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int ExtinguishingRate { get; set; }
    public int ExtinguishingSpread { get; set; }
    public int ExtinguishingCapacity { get; set; }
    public int DestroyedClearDuration { get; set; }

}