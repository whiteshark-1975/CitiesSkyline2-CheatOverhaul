namespace WhitesharkCheatOverhaul;

public interface ITransportStopOptions

{
    public float EnterDistance { get; set; }
    public float ExitDistance { get; set; }
    public float AccessDistance { get; set; }
    public float BoardingTime { get; set; }
    public float ComfortFactor { get; set; }
    public float LoadingFactor { get; set; }

}