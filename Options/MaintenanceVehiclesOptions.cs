namespace WhitesharkCheatOverhaul;

public class MaintenanceVehiclesOptions :
    IBasePrefabOptions,
    IMaintenanceVehicleOptions
{
    public string Name { get; set; } = null!;

    public int MaintenanceCapacity { get; set; }
    public int MaintenanceRate { get; set; }

}