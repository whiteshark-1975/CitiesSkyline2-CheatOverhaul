namespace WhitesharkCheatOverhaul;

public class HealthcareOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IServiceCoverageOptions,
    IHospitalOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int WaterConsumption { get; set; }
    public int ElectricityConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int ServiceCoverageCapacity { get; set; }
    public int ServiceCoverageRange { get; set; }
    public int ServiceCoverageMagnitude { get; set; }
    public int AmbulanceCapacity { get; set; }
    public int HelicopterCapacity { get; set; }
    public int PatientCapacity { get; set; }
    public int TreatmentBonus { get; set; }


}