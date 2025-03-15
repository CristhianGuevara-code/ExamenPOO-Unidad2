using ExamenPOO_U2.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenPOO_U2.Database
{
    public class PlanillaDbContext : DbContext
    {
        public PlanillaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<DetailSheetEntity> DetailSheets { get; set; }
        public DbSet<PlanillaEntity> PlanillaEntities { get; set; }

    }
}
