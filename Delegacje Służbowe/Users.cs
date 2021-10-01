using System;
using System.Security.Cryptography;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Windows.Forms;
using Delegations;
using Delegations.Interfaces;
using System.Collections.Generic;

namespace Delegations
{
    class Users : IDataBase
    {

        private readonly IConnection db_con = new LocalDB();
        

        public int Delete(int user_id)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());

            int affected = db.Query("Users").Where("Id", user_id).Delete();
            db_con.Disconnect(con);

            return affected;

        }

        public dynamic Filter(dynamic fields)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            string word = fields.word;
            var users = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Join("Departments", "Departments.Id", "Users.department").Where(q =>
                               q.WhereLike("name", $"%{word}%").OrWhereLike("surname", $"%{word}%")
                           ).OrWhere(q =>
                               q.WhereLike("login", $"%{word}%").OrWhereLike("Departments.full_name", $"%{word}%")
                           ).OrWhere(q =>
                               q.WhereLike("Roles.role_name", $"%{word}%")
                           ).Get();

            db_con.Disconnect(con);
            return users;
        }

        public dynamic Find(int user_id)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var user = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Join("Departments", "Departments.Id", "Users.department").Where("Users.Id", user_id).FirstOrDefault();
            db_con.Disconnect(con);
            return user;
        }

        public int Add(object data)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var row_id = db.Query("Users").InsertGetId<int>(data);
            db_con.Disconnect(con);
            return row_id;
        }

        public dynamic Get()
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var users = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Join("Departments", "Departments.Id", "Users.department").Get();
            db_con.Disconnect(con);
            return users;

        }

        public int Update(object data, int user_id)
        {
            var con = db_con.Connect();
            var db = new QueryFactory(con, new SqlServerCompiler());
            var affected = db.Query("Users").Where("Id", user_id).Update(data);
            db_con.Disconnect(con);
            return affected;
        }

  
    }
}
