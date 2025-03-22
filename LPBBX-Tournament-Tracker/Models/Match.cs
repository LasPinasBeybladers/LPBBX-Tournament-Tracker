using System;

namespace LPBBX_Tournament_Tracker.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public DateTime MatchDate { get; set; } = DateTime.Now;
    }
}
