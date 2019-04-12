using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _13_Sacrament_Planning.Models
{
    public class SacramentPlanningContext : DbContext
    {
        public SacramentPlanningContext (DbContextOptions<SacramentPlanningContext> options)
            : base(options)
        {
        }

        public DbSet<_13_Sacrament_Planning.Models.Hymn> Hymn { get; set; }
    }
}
