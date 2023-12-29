namespace WhitesharkCheatOverhaul;

public class CentralBankOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ICityLoanIntrest,
    ICityImportcost,
    ICityExportCost
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public float CityLoanIntrest { get; set; }
    public float CityImportcost { get; set; }
    public float CityExportCost { get; set; }

}