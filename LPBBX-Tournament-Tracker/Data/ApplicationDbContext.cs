using Microsoft.EntityFrameworkCore;
using LPBBX_Tournament_Tracker.Models;
using System.Collections.Generic;

namespace LPBBX_Tournament_Tracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
