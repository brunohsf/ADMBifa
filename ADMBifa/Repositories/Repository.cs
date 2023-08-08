using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADMBifa.Repositories
{
    public class Repository<T> where T : class
    {
        protected readonly SqlConnection _connection;

        public Repository()
            => _connection = new SqlConnection(Config.ConnectionString);

        public IEnumerable<T> Get()
            => _connection.GetAll<T>();

        public T Get(int id)
            => _connection.Get<T>(id);

        public void Create(T model)
            => _connection.Insert<T>(model);

        public void Update(T model)
            => _connection.Update<T>(model);

        public void Delete(T model)
            => _connection.Delete(model);

        public void Update(int id)
        {
            if (id != 0)
                return;

            var model = _connection.Get<T>(id);
            _connection.Update(model);
        }
    }
}
