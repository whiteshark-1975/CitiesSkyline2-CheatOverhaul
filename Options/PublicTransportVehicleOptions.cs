namespace WhitesharkCheatOverhaul;

public class PublicTransportVehicleOptions :
    IBasePrefabOptions,
    IPublicTransportVehicle
{
    public string Name { get; set; } = null!;

    public int PassengerCapacity { get; set; }
    public float Maintenancerange { get; set; }
    

}