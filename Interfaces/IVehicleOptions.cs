namespace WhitesharkCheatOverhaul;

public interface IFireEngineOptions

{
    public float ExtinguishingCapacity { get; set; }
    public float ExtinguishingRate { get; set; }
    public float ExtinguishingSpread { get; set; }
    public float DestroyedClearDuration { get; set; }

}
public interface IDeliveryTruckOptions

{
    public int CargoCapacity { get; set; }
    public int CostToDrive { get; set; }

}
public interface IGarbageTruckOptions

{
    public int GarbageTruckCapacity { get; set; }
    public int GarbageTruckUnloadRate { get; set; }
}
public interface IMaintenanceVehicleOptions

{
    public int MaintenanceCapacity { get; set; }
    public int MaintenanceRate { get; set; }
}
public interface IPostVanOptions

{
    public int MailCapacity { get; set; }

}
public interface IPoliceCarOptions

{
    public int CriminalCapacity { get; set; }
    public float CrimeReductionRate { get; set; }

}
public interface IPublicTransportVehicle

{
    public int PassengerCapacity { get; set; }
    public float Maintenancerange { get; set; }

}

