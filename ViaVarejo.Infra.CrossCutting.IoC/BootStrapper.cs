using SimpleInjector;
using ViaVarejo.Application;
using ViaVarejo.Application.Interface;
using ViaVarejo.Domain.Interfaces.Repositories;
using ViaVarejo.Domain.Interfaces.Services;
using ViaVarejo.Domain.Services;
using ViaVarejo.Infra.Data.Context;
using ViaVarejo.Infra.Data.Repositories;

namespace ViaVarejo.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ViaVarejoDbContext>(Lifestyle.Scoped);
            container.Register<IAmigoRepository, AmigoRepository>(Lifestyle.Scoped);
            container.Register<ICalculoHistoricoLogRepository, CalculoHistoricoLogRepository>(Lifestyle.Scoped);

            container.Register<IAmigoService, AmigoService>(Lifestyle.Scoped);
            container.Register<ICalculoHistoricoLogService, CalculoHistoricoLogService>(Lifestyle.Scoped);

            container.Register<IAmigoAppService, AmigoAppService>(Lifestyle.Scoped);
            container.Register<ICalculoHistoricoLogAppService, CalculoHistoricoLogAppService>(Lifestyle.Scoped);
        }
    }
}