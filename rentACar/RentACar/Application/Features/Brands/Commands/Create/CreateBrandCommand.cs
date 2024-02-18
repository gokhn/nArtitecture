using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;

    public class CreateBrandCommand : IRequest<CreatedBrandResponse>
    {
    public string Name { get; set; }

    public class CreateBrandCommandHandlar : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public CreateBrandCommandHandlar(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public  async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = _mapper.Map<Brand>(request);

            brand.Id = Guid.NewGuid();


             var result =_brandRepository.AddAsync(brand);


            CreatedBrandResponse createdBrandResponse = new();

            createdBrandResponse.Name = brand.Name;
            createdBrandResponse.Id = brand.Id;

            return createdBrandResponse;
        }
    }
}

