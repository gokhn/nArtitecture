﻿using Application.Services.Repositories;
using Core.Persistence.Respositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class TransmissionRepository : EfRepositoryBase<Transmission, Guid, BaseDbContext>, ITransmissionRepository
{
    public TransmissionRepository(BaseDbContext context) : base(context)
    {
    }
}

