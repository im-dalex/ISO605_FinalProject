using BRC.Bussiness.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TRC.Bussiness.Context
{
    public class TRCDbContext : DbContext
    {
        //public TRCDbContext(DbContextOptions<TRCDbContext> context)
        //    :base(context) { }

        #region DbSet

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<FuelType> FuelType { get; set; }
        public DbSet<Inspection> Inspection { get; set; }
        public DbSet<RentDetail> RentDetail { get; set; }
        public DbSet<ReturnDetail> ReturnDetail { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleBrand> VehicleBrand { get; set; }
        public DbSet<VehicleModel> VehicleModel { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=TRC-Developer;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
