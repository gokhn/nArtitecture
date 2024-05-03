using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public partial class ModelConfiguration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");  //Tablo ismi belirleniyor

            builder.Property(b => b.Id).HasColumnName("Id").IsRequired(); // Brand nesnesindeki Id alanı tablodaki Id degerine karislik geliyor
            builder.Property(b => b.ModelId).HasColumnName("ModelId").IsRequired();
            builder.Property(b => b.Kilometer).HasColumnName("Kilometer").IsRequired();
            builder.Property(b => b.CarState).HasColumnName("State");
            builder.Property(b => b.ModelYear).HasColumnName("ModelYear");


            builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");


            builder.HasOne(b => b.Model);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
