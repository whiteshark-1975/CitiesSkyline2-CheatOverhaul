namespace WhitesharkCheatOverhaul;

public interface IHospitalOptions

{
    public int AmbulanceCapacity { get; set; }
    public int HelicopterCapacity { get; set; }
    public int PatientCapacity { get; set; }
    public int TreatmentBonus { get; set; }

}