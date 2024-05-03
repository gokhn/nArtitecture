using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands");  //Tablo ismi belirleniyor

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired(); // Brand nesnesindeki Id alanı tablodaki Id degerine karislik geliyor
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired(); 
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.Name,name:"UK_Brands_Name").IsUnique();  //Name alani icin index olusturulur.

        builder.HasMany(b => b.Models);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
