using System;
using System.Data.SqlClient;

namespace Delegations
{


    public  interface IConnection
    {
        Boolean Status(SqlConnection con);
        SqlConnection Connect(string connectionstring);
        void Disconnect(SqlConnection con);

    }
}
