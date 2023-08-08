using ADMBifa.Models;
using Dapper;

namespace ADMBifa.Repositories
{
    public class ColaboradorRepository : Repository<Colaborador>
    {


        public Colaborador CarregarColaborador()
        {
            var sql = @"SELECT TOP (1) CodigoColaborador,
                 Nome,
                 DataContratacao,
                 LimiteBifas,
                 CodigoNivel,
                 Ativo FROM Colaborador WHERE Ativo = 1";

            return _connection.QueryFirst<Colaborador>(sql);

        }

    }
}
