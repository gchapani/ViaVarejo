using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Domain.Interfaces.Services
{
    public interface IAmigoService : IServiceBase<Amigo>
    {
        Amigo BuscarPorPosicao(decimal posX, decimal posY);
    }
}