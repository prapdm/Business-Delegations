using Delegations.Interfaces;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;

namespace Delegations
{
    public class Departaments : IDataBase
    {

        private readonly IConnection db_con = new LocalDB();




        public int Add(object data)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var row_id = db.Query("Departments").InsertGetId<int>(data);
            db_con.Disconnect(con);
            return row_id; throw new NotImplementedException();
        }

        public int  Delete(int row_id)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            int affected = db.Query("Departments").Where("Id", row_id).Delete();
            db_con.Disconnect(con);
            return affected;
        }

        public dynamic Filter(dynamic fields)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            string word = fields.word;
            var departament = db.Query("Departments").Where(q =>
                               q.WhereLike("full_name", $"%{word}%")
                           ).Get();

            db_con.Disconnect(con);
            return departament;
        }

        public dynamic Find(int row_id)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var departament = db.Query("Departments").Where("Departments.Id", row_id).FirstOrDefault();
            db_con.Disconnect(con);
            return departament;
        }

        public int GetIdByName(string word)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var departament = db.Query("Departments").Where("full_name", word).FirstOrDefault();
            db_con.Disconnect(con);
            return departament.Id;

        }

 

        public dynamic Get()
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var departments = db.Query("Departments").Get();
            db_con.Disconnect(con);
            return departments;
        }

        public int Update(object data, int row_id)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var affected = db.Query("Departments").Where("Id", row_id).Update(data);
            db_con.Disconnect(con);
            return affected;
        }
    }
}
