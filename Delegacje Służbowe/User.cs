using System;
using System.Security.Cryptography;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Windows.Forms;

namespace Delegacje_Służbowe
{
    class User
    {
        public string PasswordHash(string password)
        {
            //Create the salt value with a cryptographic PRNG:
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //Create the Rfc2898DeriveBytes and get the hash value:
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            //Combine the salt and password bytes for later use:

            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            //Turn the combined salt+hash into a string for storage
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        public Boolean VerifyPassword(string enteredPassword, string hashedPassowrd)
        {
            // Extract the bytes 
            byte[] hashBytes = Convert.FromBase64String(hashedPassowrd);
            //  Get the salt 
            byte[] salt = new byte[16];

            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash on the password the user entered 
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compare the results 
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;
            //Debug.WriteLine("hashBytes - " + i + hashBytes[i + 16] + " hash - " + i + hash[i]);

            return true;
        }

        public void DeleteUser(int user_id, UsersList ul)
        {

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            int affected  = db.Query("Users").Where("Id", user_id).Delete();

            if (affected == 1)
            {
                MessageBox.Show("Użytkownik o identyfikatorze " + user_id + " został usunięty.", "Potwierdzenie usunięcia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                ul.FillDataGrid();
            }
            else
            {
                MessageBox.Show("Użytkownik o identyfikatorze " + user_id + " nie został usunięty.", "Błąd",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }



        }




    }
}
