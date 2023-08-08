using ADMBifa.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMBifa.Repositories
{
    public class ColaboradorRepository : Repository<Colaborador>
    {
        private readonly SqlConnection _connection;

        public ColaboradorRepository(SqlConnection connection)
            => _connection = connection;


    }
}
