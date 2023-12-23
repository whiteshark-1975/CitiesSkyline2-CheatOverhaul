namespace WhitesharkCheatOverhaul;

public class MaintenanceVehiclesOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int MaintenanceCapacity { get; set; }
    public int MaintenanceRate { get; set; }

}