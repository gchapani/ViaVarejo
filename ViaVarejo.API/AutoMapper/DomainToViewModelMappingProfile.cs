using AutoMapper;
using ViaVarejo.Domain.Entities;
using ViaVarejo.API.ViewModels;

namespace ViaVarejo.API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AmigoViewModel, Amigo>();
                cfg.CreateMap<CalculoHistoricoLogViewModel, CalculoHistoricoLog>();
            });

            IMapper mapper = config.CreateMapper();

            var sourceAmigo = new AmigoViewModel();
            var destAmigo = mapper.Map<AmigoViewModel, Amigo>(sourceAmigo);

            var sourceCalculoHistoricoLog = new CalculoHistoricoLogViewModel();
            var destCalculoHistoricoLog = mapper.Map<CalculoHistoricoLogViewModel, CalculoHistoricoLog>(sourceCalculoHistoricoLog);
        }
    }
}