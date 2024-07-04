using Atm.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atm.Api.Data.Configurations
{
    public class AtmEntityConfiguration : IEntityTypeConfiguration<AtmMachine>
    {
    

        public void Configure(EntityTypeBuilder<AtmMachine> builder)
        {
            builder.HasKey(a => a.Id);

            
            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Longitude).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Latitude).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Adress).IsRequired().HasMaxLength(200);
            builder.Property(a => a.DistrictId).IsRequired();
            builder.Property(a => a.CityId).IsRequired();

            builder.Property(a => a.IsActive).IsRequired();

            builder.HasOne(a => a.District)
                   .WithMany(d => d.AtmMachines)
                   .HasForeignKey(a => a.DistrictId)
                   .OnDelete(DeleteBehavior.Restrict); 
            ;
            builder.HasOne(a => a.City)
                  .WithMany(d => d.AtmMachines)
                  .HasForeignKey(a => a.CityId)
                  .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
