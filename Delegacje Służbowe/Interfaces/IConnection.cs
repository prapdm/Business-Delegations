using System;
using System.Data.SqlClient;

namespace Delegations
{
    interface IConnection
    {
        Boolean Status(SqlConnection con);
        SqlConnection Connect();
        void Disconnect(SqlConnection con);

    }
}
