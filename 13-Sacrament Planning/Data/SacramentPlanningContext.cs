using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _13_Sacrament_Planning.Models;

namespace _13_Sacrament_Planning.Models
{
    public class SacramentPlanningContext : DbContext
    {
        public SacramentPlanningContext (DbContextOptions<SacramentPlanningContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speaker>()
                .HasKey(s => new { s.MemberID, s.MeetingID });
        }

        public DbSet<_13_Sacrament_Planning.Models.Hymn> Hymn { get; set; }

        public DbSet<_13_Sacrament_Planning.Models.Member> Member { get; set; }

        public DbSet<_13_Sacrament_Planning.Models.Meeting> Meeting { get; set; }
    }
}
