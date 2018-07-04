using System.Collections;
using System.Collections.Generic;
using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Domain.Interfaces.Repositories
{
    public interface ICalculoHistoricoLogRepository : IRepositoryBase<CalculoHistoricoLog>
    {
        IEnumerable<CalculoHistoricoLog> BuscarPorId(int id);
    }
}
