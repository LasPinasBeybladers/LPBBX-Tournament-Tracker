namespace LPBBX_Tournament_Tracker.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TournamentId { get; set; }
        public int TotalPoints { get; set; }
        public int SpinFinishes { get; set; }
        public int OverFinishes { get; set; }
        public int BurstFinishes { get; set; }
        public int ExtremeFinishes { get; set; }
    }
}
