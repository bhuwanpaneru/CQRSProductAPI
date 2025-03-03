using Microsoft.EntityFrameworkCore;
using CQRSProductAPI.Domain.Entities;

namespace CQRSProductAPI.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } //demo
        public DbSet<LineMaster> LineMaster { get; set; }
        public DbSet<ManualMaster> ManualMaster { get; set; }
        public DbSet<FaultMaster> FaultMaster { get; set; }
        public DbSet<StationMaster> StationMaster { get; set; }
        public DbSet<AreaMaster> AreaMaster { get; set; }
        public DbSet<EquipmentMaster> EquipmentMaster { get; set; }
        public DbSet<PlantMaster> PlantMaster { get; set; }
        public DbSet<ShiftMaster> ShiftMaster { get; set; }
        public DbSet<ShopMaster> ShopMaster { get; set; }
        public DbSet<SpareEquipmentMapping> SpareEquipmentMapping { get; set; }
        public DbSet<SpareMaster> SpareMaster { get; set; }
        public DbSet<TeamMaster> TeamMaster { get; set; }
    }
}
