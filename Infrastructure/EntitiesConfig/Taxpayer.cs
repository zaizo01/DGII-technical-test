using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfig
{
    public class TaxpayerConfig : IEntityTypeConfiguration<Taxpayer>
    {
        public void Configure(EntityTypeBuilder<Taxpayer> builder)
        {
            builder.Property(prop => prop.Name)
                   .IsRequired();

        }
    }
}
