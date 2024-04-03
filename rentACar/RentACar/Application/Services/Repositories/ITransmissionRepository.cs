using Domain.Entities;
using Core.Persistence.Respositories;

namespace Application.Services.Repositories;

public interface ITransmissionRepository : IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
{
}


