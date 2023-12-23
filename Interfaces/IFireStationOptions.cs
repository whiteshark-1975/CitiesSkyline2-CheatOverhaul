namespace WhitesharkCheatOverhaul;

public interface IFireStationOptions

{
    public int FireEngineCapacity { get; set; }
    public int FireHelicopterCapacity { get; set; }
    public float VehicleEfficiency { get; set; }
    public int DisasterResponseCapacity { get; set; }

}