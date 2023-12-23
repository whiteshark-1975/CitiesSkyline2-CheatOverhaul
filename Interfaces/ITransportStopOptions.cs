namespace WhitesharkCheatOverhaul;

public interface ITransportStopOptions

{
    public int EnterDistance { get; set; }
    public int ExitDistance { get; set; }
    public int AccessDistance { get; set; }
    public int BoardingTime { get; set; }
    public int ComfortFactor { get; set; }
    public int LoadingFactor { get; set; }

}