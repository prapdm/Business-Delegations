using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Security.Cryptography;

namespace Delegations
{
    class Autentication : IAutentication
    {

        public int Loged_user { get; private set; }


        public int GetID()
        {
            return Loged_user;
        }


        public bool Login(string login, string password)
        {
            IConnection db_con = new LocalDB();
            var con = db_con.Connect();

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(con, compiler);
            var user = db.Query("Users").Where("status", 1).Where("login", login).FirstOrDefault();

            if (user != null)
            {
                byte[] hashBytes = Convert.FromBase64String(user.password);
                byte[] salt = new byte[16];

                Array.Copy(hashBytes, 0, salt, 0, 16);

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);

                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        return false;

                Loged_user = user.Id;
                db_con.Disconnect(con);

                return true;

            }
            else return false;


        }
    }
}
