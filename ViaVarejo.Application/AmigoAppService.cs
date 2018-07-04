using ViaVarejo.Application.Interface;
using ViaVarejo.Domain.Entities;
using ViaVarejo.Domain.Interfaces.Services;

namespace ViaVarejo.Application
{
    public class AmigoAppService : AppServiceBase<Amigo>, IAmigoAppService
    {
        private readonly IAmigoService _amigoService;

        public AmigoAppService(IAmigoService amigoService)
            : base(amigoService)
        {
            _amigoService = amigoService;
        }

        public Amigo BuscarPorPosicao(decimal posX, decimal posY)
        {
            return _amigoService.BuscarPorPosicao(posX, posY);
        }
    }
}