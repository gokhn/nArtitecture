using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public partial class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("Models");  //Tablo ismi belirleniyor

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired(); // Brand nesnesindeki Id alanı tablodaki Id degerine karislik geliyor
        builder.Property(b => b.Id).HasColumnName("Name").IsRequired();

        builder.Property(b => b.BrandId).HasColumnName("BrandId").IsRequired();
        builder.Property(b => b.FuelId).HasColumnName("FuelId").IsRequired();
        builder.Property(b => b.TransmissionId).HasColumnName("TransmissionId").IsRequired();
        builder.Property(b => b.DailyPrice).HasColumnName("DailyPrice").IsRequired();
        builder.Property(b => b.ImageUrl).HasColumnName("ImageUrl").IsRequired();



        builder.Property(b => b.Id).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.Id).HasColumnName("UpdatedDate");
        builder.Property(b => b.Id).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.Name, name: "UK_Models_Name").IsUnique();

        builder.HasOne(b => b.Brand);
        builder.HasOne(b => b.Transmission);
        builder.HasOne(b => b.Fuel);
        builder.HasMany(b => b.Cars);


        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
