using System.Collections.Generic;
using System.Linq;
using ViaVarejo.Domain.Entities;
using ViaVarejo.Domain.Interfaces.Repositories;

namespace ViaVarejo.Infra.Data.Repositories
{
    public class CalculoHistoricoLogRepository : RepositoryBase<CalculoHistoricoLog>, ICalculoHistoricoLogRepository
    {
        public IEnumerable<CalculoHistoricoLog> BuscarPorId(int id)
        {
            return Db.CalculoHistoricoLog.Where(p => p.IDAmigoA == id);
        }
    }
}