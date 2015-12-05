using AutoMapper;
using GAP.ArquivoPassivo.ViewModels;
using GAP_Arquivamento.Dominio.Entidades;

namespace GAP.ArquivoPassivo.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Arquivo, ArquivoViewModel>();
            Mapper.CreateMap<Pasta, PastaViewModel>();
        }
    }
}