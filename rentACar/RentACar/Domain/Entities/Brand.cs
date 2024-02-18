using Core.Persistence.Respositories;

namespace Domain.Entities;

    //Database Nesneleri

    public class Brand :Entity<Guid>
    {
    public string Name { get; set; }
}
