using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Atm.Api.Data.Entities;
namespace Atm.Api.Data.Configurations
{
    public class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c=>c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar(20)");

            builder.HasMany(c => c.Districts)
                   .WithOne(d => d.City)
                   .HasForeignKey(d => d.CityId);

            builder.HasMany(c => c.AtmMachines)
                   .WithOne(d => d.City)
                   .HasForeignKey(d => d.CityId);        }
    }
}
