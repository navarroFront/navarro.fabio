using AutoMapper;
using DDDPosUnivem.Domain.Entities;
using DDDPosUnivem.MVC.ViewModels;

namespace DDDPosUnivem.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }



}