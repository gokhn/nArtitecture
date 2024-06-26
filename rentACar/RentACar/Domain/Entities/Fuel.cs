﻿using Core.Persistence.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Fuel : Entity<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }

    public Fuel()
    {
        Models = new HashSet<Model>();
    }

    public Fuel(Guid id, string name)
        : this()
    {
        Id = id;
        Name = name;
    }

}
