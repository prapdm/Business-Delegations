using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Delegations
{
    class Autentication : IAutentication
    {

        public int Loged_user { get; private set; }
        private readonly string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $@"{Application.StartupPath}Database.mdf;" + @"Integrated Security=True;Connect Timeout=30";



        public int GetID()
        {
            return Loged_user;
        }


        public bool Login(string login, string password)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect(connectionstring);

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(con, compiler);
            var user = db.Query("Users").Where("status", 1).Where("login", login).FirstOrDefault();
            db_con.Disconnect(con);
            if (user != null)
            {
                var passwordhasher = new PasswordHasher();
                var result = passwordhasher.ComparePassword(password, user.password);

                if (result)
                {
                    Loged_user = user.Id;
                    return true;

                }
                else
                    return false;


            }
            else return false;


        }
    }
}
