using ViaVarejo.Domain.Entities;
using ViaVarejo.Domain.Interfaces.Repositories;
using ViaVarejo.Domain.Interfaces.Services;

namespace ViaVarejo.Domain.Services
{
    public class AmigoService : ServiceBase<Amigo>, IAmigoService
    {
        private readonly IAmigoRepository _amigoRepository;

        public AmigoService(IAmigoRepository amigoRepository)
            : base(amigoRepository)
        {
            _amigoRepository = amigoRepository;
        }

        public Amigo BuscarPorPosicao(decimal posX, decimal posY)
        {
            return _amigoRepository.BuscarPorPosicao(posX, posY);
        }
    }
}
