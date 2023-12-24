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
    public int TelecomNeed { get; set; }
    public float ServiceCoverageCapacity { get; set; }
    public float ServiceCoverageRange { get; set; }
    public float ServiceCoverageMagnitude { get; set; }
    public int AmbulanceCapacity { get; set; }
    public int HelicopterCapacity { get; set; }
    public int PatientCapacity { get; set; }
    public int TreatmentBonus { get; set; }


}