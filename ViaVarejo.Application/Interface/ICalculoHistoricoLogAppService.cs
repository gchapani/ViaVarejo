using System.Collections.Generic;
using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Application.Interface
{
    public interface ICalculoHistoricoLogAppService : IAppServiceBase<CalculoHistoricoLog>
    {
        IEnumerable<CalculoHistoricoLog> BuscarPorId(int id);
    }
}