using System.Collections.Generic;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class RoleRepository
    {
        private SqlConnection _connection;

        public RoleRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Role> Get()
            => _connection.GetAll<Role>();

        public Role Get(int id)
            => _connection.Get<Role>(id);
        
        public void Create(Role role)
            => _connection.Insert<Role>(role);
        
        public void Update(Role role)
        {
            if (role.Id != 0)
                _connection.Update<Role>(role);
        }

        public void Delete(Role role)
            => _connection.Delete<Role>(role);

        public void Delete(int id)
        {
            if (id != 0)
                return;

            var Role = _connection.Get<Role>(id);
            _connection.Delete<Role>(Role);
        }

    }
}
