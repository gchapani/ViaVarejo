using AutoMapper;
using ViaVarejo.Domain.Entities;
using ViaVarejo.API.ViewModels;

namespace ViaVarejo.API.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Amigo, AmigoViewModel>();
                cfg.CreateMap<CalculoHistoricoLog, CalculoHistoricoLogViewModel>();
            });

            IMapper mapper = config.CreateMapper();

            var sourceAmigo = new Amigo();
            var destAmigo = mapper.Map<Amigo, AmigoViewModel>(sourceAmigo);

            var sourceCalculoHistoricoLog = new CalculoHistoricoLog();
            var destCalculoHistoricoLog = mapper.Map<CalculoHistoricoLog, CalculoHistoricoLogViewModel>(sourceCalculoHistoricoLog);
        }
    }
}