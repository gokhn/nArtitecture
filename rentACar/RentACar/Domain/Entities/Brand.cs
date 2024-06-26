﻿using Core.Persistence.Respositories;

namespace Domain.Entities;

    //Database Nesneleri

    public class Brand :Entity<Guid>
    {
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }

    public Brand()
    {
        Models = new HashSet<Model>();
    }
    //this() parametresiz olan constructor da calissin
    public Brand(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}
