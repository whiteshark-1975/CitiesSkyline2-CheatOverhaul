namespace WhitesharkCheatOverhaul;

public interface IPostFacilityOptions

{
    public int MailboxCapacity { get; set; }
    public int PostVanCapacity { get; set; }
    public int MailStorageCapacity { get; set; }
    public int PostTrucksCapacity { get; set; }
    public int SortingRate { get; set; }

}