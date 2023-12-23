namespace WhitesharkCheatOverhaul;

public interface IGarbageFacilityOption
{
    public int GarbageCapacity { get; set; }
    public int GarbageVehicleCapacity { get; set; }
    public int GarbageTransportCapacity { get; set; }
    public int GarbageProcessingspeed { get; set; }

}