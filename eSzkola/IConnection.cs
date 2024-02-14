using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eSzkola
{
    internal interface IConnection
    {
        SqlConnection OpenConnection();

        void CloseConnection();

        void ExecuteQuery(SqlConnection connection, string query);
    }
}
