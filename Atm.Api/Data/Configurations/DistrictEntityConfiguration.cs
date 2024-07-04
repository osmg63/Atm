
using Atm.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atm.Api.Data.Configurations;


public class DistrictEntityConfiguration : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.HasKey(d => d.Id);
        builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar(20)");


        builder.HasOne(d => d.City)
               .WithMany(c => c.Districts)
               .HasForeignKey(d => d.CityId);


        builder.HasMany(d => d.AtmMachines)
                  .WithOne(a => a.District)
                  .HasForeignKey(d => d.DistrictId);



    }
}
