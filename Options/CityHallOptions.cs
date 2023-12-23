namespace WhitesharkCheatOverhaul;

public class CityHallOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ICityLoanIntrest,
    ICityImportcost
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float CityLoanIntrest { get; set; }
    public float CityImportcost { get; set; }


}