using System.Collections.Generic;
using ViaVarejo.Application.Interface;
using ViaVarejo.Domain.Entities;
using ViaVarejo.Domain.Interfaces.Services;

namespace ViaVarejo.Application
{
    public class CalculoHistoricoLogAppService  : AppServiceBase<CalculoHistoricoLog>, ICalculoHistoricoLogAppService
    {
        private readonly ICalculoHistoricoLogService _calculoHistoricoLogService;

        public CalculoHistoricoLogAppService(ICalculoHistoricoLogService calculoHistoricoLogService)
            : base(calculoHistoricoLogService)
        {
            _calculoHistoricoLogService = calculoHistoricoLogService;
        }

        public IEnumerable<CalculoHistoricoLog> BuscarPorId(int id)
        {
            return _calculoHistoricoLogService.BuscarPorId(id);
        }
    }
}
