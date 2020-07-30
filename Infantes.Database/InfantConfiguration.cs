using Infantes.Domain;
using Infantes.Domain.Enums;
using Infantes.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infantes.Database
{
    public sealed class InfantConfiguration : IEntityTypeConfiguration<Infant>
    {
        public void Configure(EntityTypeBuilder<Infant> builder)
        {
            builder.HasKey(infant => infant.Id); 
            builder.Property(infant => infant.Id).ValueGeneratedOnAdd().IsRequired();

            builder.OwnsOne(infant => infant.InfantMetric, metric =>
            {
                metric.Property(p => p.Perimeter).HasColumnName(nameof(Metric.Perimeter));
                metric.Property(p => p.Length).HasColumnName(nameof(Metric.Length));
                metric.Property(p => p.Weight).HasColumnName(nameof(Metric.Weight)); 
            });

            //var infant = InfantFactory.GetNewInfantObject(
            //       "Nene1", DateTime.Now, 20m, 20m, 3m, Domain.Enums.Sex.Female);

            builder.HasData(new
            {
                Id = 1,
                Name = "Nene",
                Sex = Sex.Female,
                Perimeter = 2m,
                Birthdate = DateTime.Now
            });
        }
    }
}