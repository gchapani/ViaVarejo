using System.Collections.Generic;
using System.Linq;
using ViaVarejo.Domain.Entities;
using ViaVarejo.Domain.Interfaces.Repositories;

namespace ViaVarejo.Infra.Data.Repositories
{
    public class AmigoRepository : RepositoryBase<Amigo>, IAmigoRepository
    {
        public Amigo BuscarPorPosicao(decimal posX, decimal posY)
        {
            return Db.Amigo.Where(p => p.PosX == posX && p.PosY == posY).FirstOrDefault();
        }
    }
}
