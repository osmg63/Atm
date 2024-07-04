using Atm.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atm.Api.Data.Configurations
{
    public class PersonelEntityConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p=>p.SurName)
                .HasMaxLength(20)
                .HasColumnType("nvarchar(20)");

            builder.Property(p => p.JobId).HasColumnType("int");

            builder.Property(p => p.Age).HasColumnType("smallint");


        }
    }
}
