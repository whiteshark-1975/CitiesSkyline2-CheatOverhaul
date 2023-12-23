namespace WhitesharkCheatOverhaul;

public class DeliveryTruckOptions :
    IBasePrefabOptions

{
    public string Name { get; set; } = null!;

    public int CargoCapacity { get; set; }
    public int CostToDrive { get; set; }

}