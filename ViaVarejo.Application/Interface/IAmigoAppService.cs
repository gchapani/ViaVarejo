using System.Collections.Generic;
using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Application.Interface
{
    public interface IAmigoAppService : IAppServiceBase<Amigo>
    {
        Amigo BuscarPorPosicao(decimal posX, decimal posY);
    }
}