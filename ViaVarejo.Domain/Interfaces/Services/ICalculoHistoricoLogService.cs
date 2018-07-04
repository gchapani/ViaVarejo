using System.Collections.Generic;
using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Domain.Interfaces.Services
{
    public interface ICalculoHistoricoLogService : IServiceBase<CalculoHistoricoLog>
    {
        IEnumerable<CalculoHistoricoLog> BuscarPorId(int id);
    }
}