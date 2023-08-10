using ADMBifa.Models;
using ADMBifa.Results;
using Dapper;
using System.Collections.Generic;

namespace ADMBifa.Repositories
{
    public class ColaboradorRepository : Repository<Colaborador>
    {
        public Colaborador CarregarPrimeiroColaborador()
        {
            var sql = @"SELECT TOP (1) CodigoColaborador,
                 Nome,
                 DataContratacao,
                 LimiteBifas,
                 CodigoNivel,
                 Ativo FROM Colaborador WHERE Ativo = @Ativo";

            return _connection.QueryFirstOrDefault<Colaborador>(sql, new
            {
                Ativo = 1
            });

        }

        public IEnumerable<ListarColaboradorResult> ListarColaboradores(string busca)
        {
            var sql = @"SELECT C.CodigoColaborador,
                               C.Nome,
                               N.Descricao
                        FROM Colaborador AS C
                            INNER JOIN Nivel AS N
                                ON N.CodigoNivel = C.CodigoNivel
                        WHERE Nome LIKE @Busca
                            AND Ativo = @Ativo;";


            return _connection.Query<ListarColaboradorResult>(sql, new
            {
                Ativo = 1,
                Busca = $"{busca}%"
            });
        }
    }
}