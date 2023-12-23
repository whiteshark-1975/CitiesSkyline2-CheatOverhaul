namespace WhitesharkCheatOverhaul;

public class GarbagetruckOptions :
    IBasePrefabOptions,
    IGarbageTruckOptions
{
    public string Name { get; set; } = null!;

    public int GarbageTruckCapacity { get; set; }
    public int GarbageTruckUnloadRate { get; set; }

}