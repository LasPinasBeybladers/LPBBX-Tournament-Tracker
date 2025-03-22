using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace LPBBX_Tournament_Tracker.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string TournamentId { get; set; }  // Custom ID input
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<Player> Players { get; set; } = new List<Player>();
        public List<Match> Matches { get; set; } = new List<Match>();
        public bool IsCompleted { get; set; }
    }
}
