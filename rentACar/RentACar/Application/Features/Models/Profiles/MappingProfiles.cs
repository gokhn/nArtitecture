﻿using Application.Features.Models.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles() 
    {
        //Aslında Isım benzerligi oldugu icin .ForMember  fonksiyonu kullanılmasa bile  BrandName nesnesi dolacaktır.
        // Or: Brand objesindeki Name ozelligi => BrandName
        //Farklı isimlerdeki propertyleri eslestirmek icin .ForMember() kullanilmaidir.

        CreateMap<Model,GetListModelListItemDto>()
            .ForMember(destinationMember: c => c.BrandName, memberOptions: opt => opt.MapFrom(c => c.Brand.Name))
            .ForMember(destinationMember: c => c.FuelName, memberOptions: opt => opt.MapFrom(c => c.Fuel.Name))
            .ForMember(destinationMember: c => c.TransmissionName, memberOptions: opt => opt.MapFrom(c => c.Transmission.Name))
            .ReverseMap();

        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();
    }
}
