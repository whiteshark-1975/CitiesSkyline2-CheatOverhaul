namespace WhitesharkCheatOverhaul;

public class CentralBankOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float CityLoanIntrest { get; set; }
    public float CityImportCost { get; set; }
    public float CityExportCost { get; set; }

}