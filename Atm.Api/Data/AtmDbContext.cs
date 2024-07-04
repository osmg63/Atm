using Atm.Api.Data.Configurations;
using Atm.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Atm.Api.DataAccess;

public class AtmDbContext : DbContext
{
    public AtmDbContext(DbContextOptions<AtmDbContext> options):base(options)
    {
        
    }

    public DbSet<Personel> Personels { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<AtmMachine> AtmMachines { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonelEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CityEntityConfiguration());
        modelBuilder.ApplyConfiguration(new DistrictEntityConfiguration());
        modelBuilder.ApplyConfiguration(new AtmEntityConfiguration());
    }
    

}
