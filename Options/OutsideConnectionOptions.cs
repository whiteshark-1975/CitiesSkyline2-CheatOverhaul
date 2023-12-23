namespace WhitesharkCheatOverhaul;

public class OutsideConnectionOptions :
    IBasePrefabOptions,
    IStorageLimitOptions,
    ISchoolOptions,
    IHospitalOptions,
    IGarbageFacilityOption,
    IFireStationOptions,
    IPoliceStationOptions,
    IDeathcareFacilityOptions,
    ITransportDepotOptions,
    ITrafficSpawnerOptions
{
    public string Name { get; set; } = null!;

    public int StorageLimit { get; set; }
    public int StudentCapacity { get; set; }
    public float GraduationModifier { get; set; }
    public int AmbulanceCapacity { get; set; }
    public int HelicopterCapacity { get; set; }
    public int PatientCapacity { get; set; }
    public int TreatmentBonus { get; set; }
    public int GarbageCapacity { get; set; }
    public int GarbageVehicleCapacity { get; set; }
    public int GarbageTransportCapacity { get; set; }
    public int GarbageProcessingspeed { get; set; }
    public int FireEngineCapacity { get; set; }
    public int FireHelicopterCapacity { get; set; }
    public int DisasterResponseCapacity { get; set; }
    public float VehicleEfficiency { get; set; }
    public int PatrolCarCapacity { get; set; }
    public int PoliceHelicopterCapacity { get; set; }
    public int JailCapacity { get; set; }
    public int HearseCapacity { get; set; }
    public int StorageCapacity { get; set; }
    public float ProcessingRate { get; set; }
    public int VehicleCapacity { get; set; }
    public float MaintenanceDuration { get; set; }
    public float ProductionDuration { get; set; }
    public float TrafficSpawnerRate { get; set; }
    
}