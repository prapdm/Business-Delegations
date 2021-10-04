using Delegations.Interfaces;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Windows.Forms;

namespace Delegations 
{
    public class Roles : IDataBase
    {

        private readonly IConnection db_con = new LocalDB();
        private readonly string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $@"{Application.StartupPath}Database.mdf;" + @"Integrated Security=True;Connect Timeout=30";

        public int Add(object data)
        {
            var con = db_con.Connect(connectionstring);
            var db = new QueryFactory(con, new SqlServerCompiler());
            var row_id = db.Query("Roles").InsertGetId<int>(data);
            db_con.Disconnect(con);
            return row_id;
        }

        public int Delete(int row_id)
        {
            var con = db_con.Connect(connectionstring);
            var db = new QueryFactory(con, new SqlServerCompiler());
            int affected = db.Query("Roles").Where("Id", row_id).Delete();
            db_con.Disconnect(con);
            return affected;
        }

        public dynamic Filter(dynamic fields)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect(connectionstring);
            var db = new QueryFactory(con, new SqlServerCompiler());
            string word = fields.word;
            var roles = db.Query("Role").Where(q =>
                               q.WhereLike("role_name", $"%{word}%")
                           ).Get();

            db_con.Disconnect(con);
            return roles;
        }

        public dynamic Find(int row_id)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect(connectionstring);
            var db = new QueryFactory(con, new SqlServerCompiler());
            var role = db.Query("Roles").Where("Id", row_id).FirstOrDefault();
            db_con.Disconnect(con);
            return role;
        }

 

        public dynamic Get()
        {
            var con = db_con.Connect(connectionstring);
            var db = new QueryFactory(con, new SqlServerCompiler());
            var roles = db.Query("Roles").Get();
            db_con.Disconnect(con);
            return roles;
        }

        public int Update(object data, int row_id)
        {
            var con = db_con.Connect(connectionstring);
            var db = new QueryFactory(con, new SqlServerCompiler());
            var affected = db.Query("Roles").Where("Id", row_id).Update(data);
            db_con.Disconnect(con);
            return affected;
        }
    }
}
