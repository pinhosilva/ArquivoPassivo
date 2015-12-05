using AutoMapper;
using GAP.ArquivoPassivo.ViewModels;
using GAP_Arquivamento.Dominio.Entidades;

namespace GAP.ArquivoPassivo.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ArquivoViewModel, Arquivo>();
            Mapper.CreateMap<PastaViewModel, Pasta>();
        }
    }
}