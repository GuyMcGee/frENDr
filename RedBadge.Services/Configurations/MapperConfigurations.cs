﻿using AutoMapper;
using Redbadge.Data.Entities;
using RedBadge.Models.IndividualResultsModels;

namespace RedBadge.Services.Configurations
{
    public class MapperConfigurations : Profile
    {
        public MapperConfigurations()
        {
            CreateMap<IndividualResultsEntity, IRCreate>().ReverseMap();
        }
    }
}
// Keeping this here in case I decide to use it in the future