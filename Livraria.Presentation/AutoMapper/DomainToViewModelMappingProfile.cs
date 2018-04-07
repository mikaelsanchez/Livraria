using AutoMapper;
using Livraria.Domain.Entities;
using Livraria.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Presentation.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<LivroViewModel, Livro>();
        }
    }
}