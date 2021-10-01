using System;
using Delegations.Interfaces;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegations
{
    public class Delegation : IDataBase
    {
        private readonly IConnection db_con = new LocalDB();
 


        public int Add(object data)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var row_id = db.Query("Delegations").InsertGetId<int>(data);
            db_con.Disconnect(con);
            return row_id;  
        }

        public int Delete(int row_id)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            int affected = db.Query("Delegations").Where("Id", row_id).Delete();
            db_con.Disconnect(con);
            return affected;
        }

        public dynamic Filter(dynamic fields)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            if (fields.user_id == 0)
            {
                string word = fields.word;
                DateTime from_date = fields.from_date;
                DateTime to_date = fields.to_date;
      
                var query = db.Query("Delegations AS dl").Join("Users AS u", "dl.user_id", "u.Id").Join("Departments AS dp", "u.department", "dp.Id");

                if (!String.IsNullOrEmpty(word))
                {
                    query.Where(q =>
                                       q.WhereLike("u.name", $"%{word}%").OrWhereLike("u.surname", $"%{word}%")
                                   ).OrWhere(q =>
                                       q.WhereLike("dp.full_name", $"%{word}%").OrWhereLike("dl.target", $"%{word}%")
                                   );
                }

                query.WhereDate("dl.from_date", ">=", from_date).WhereDate("dl.to_date", "<=", to_date);
                var delegations = query.Get();

                db_con.Disconnect(con);
                return delegations;
            }
            else
            {
                int user_id = fields.user_id;
                var delegations = db.Query("Delegations AS dl").
                    Where("user_id", user_id).Get();

                db_con.Disconnect(con);
                return delegations;

            }
            
        }

        public dynamic Find(int row_id)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var delegation = db.Query("Delegations").Where("Id", row_id).FirstOrDefault();
            db_con.Disconnect(con);
            return delegation;
        }

        public dynamic Get()
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var  from_date = DateTime.Today.AddMonths(-12);
            var to_date = DateTime.Today.AddMonths(1);

            var delegations = db.Query("Delegations AS dl").Join("Users AS u", "dl.user_id", "u.Id").Join("Departments AS dp", "u.department", "dp.Id")
                 .WhereDate("dl.from_date", ">=", Convert.ToDateTime(from_date)).WhereDate("dl.to_date", "<=", Convert.ToDateTime(to_date)).Get();
            db_con.Disconnect(con);
            return delegations;
        }

        public int Update(object data, int row_id)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var affected = db.Query("Delegations").Where("Id", row_id).Update(data);
            db_con.Disconnect(con);
            return affected;
        }
    }
}
