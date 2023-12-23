namespace WhitesharkCheatOverhaul;

public interface IVehicleOptions

{
    public int Attractiveness { get; set; }

}
public interface IFireEngineOptions

{
    public int ExtinguishingCapacity { get; set; }
    public int ExtinguishingRate { get; set; }
    public int ExtinguishingSpread { get; set; }
    public int DestroyedClearDuration { get; set; }

}
public interface IDeliveryTruckOptions

{
    public int CargoCapacity { get; set; }
    public int CostToDrive { get; set; }

}
public interface IGarbageTruckOptions

{
    public int GarbageTruckCapacity { get; set; }
    public int GarbaheTruckUnloadRate { get; set; }
}