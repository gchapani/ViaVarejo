using System.Collections.Generic;
using ViaVarejo.Domain.Entities;
using ViaVarejo.Domain.Interfaces.Repositories;
using ViaVarejo.Domain.Interfaces.Services;

namespace ViaVarejo.Domain.Services
{
    public class CalculoHistoricoLogService : ServiceBase<CalculoHistoricoLog>, ICalculoHistoricoLogService
    {
        private readonly ICalculoHistoricoLogRepository _calculoHistoricoLogRepository;

        public CalculoHistoricoLogService(ICalculoHistoricoLogRepository calculoHistoricoLogRepository)
            : base(calculoHistoricoLogRepository)
        {
            _calculoHistoricoLogRepository = calculoHistoricoLogRepository;
        }

        public IEnumerable<CalculoHistoricoLog> BuscarPorId(int id)
        {
            return _calculoHistoricoLogRepository.BuscarPorId(id);
        }
    }
}