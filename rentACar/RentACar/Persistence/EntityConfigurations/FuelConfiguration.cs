using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class FuelConfiguration : IEntityTypeConfiguration<Fuel>
{
    public void Configure(EntityTypeBuilder<Fuel> builder)
    {
        builder.ToTable("Fuels");  //Tablo ismi belirleniyor

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired(); // Brand nesnesindeki Id alanı tablodaki Id degerine karislik geliyor
        builder.Property(b => b.Id).HasColumnName("Name").IsRequired();
        builder.Property(b => b.Id).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.Id).HasColumnName("UpdatedDate");
        builder.Property(b => b.Id).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.Name, name: "UK_Fuels_Name").IsUnique();

        builder.HasMany(b => b.Models);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
