using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Domain.Interfaces.Repositories
{
    public interface IAmigoRepository : IRepositoryBase<Amigo>
    {
        Amigo BuscarPorPosicao(decimal posX, decimal posY);
    }
}