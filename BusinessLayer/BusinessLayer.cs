using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    static public class LoginFacade
    {
        public static void HashPassword(string password, out string hash, out string salt)
        {
            var saltBytes = new byte[128];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            salt = Convert.ToBase64String(saltBytes);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            hash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
        }

        public static string AuthenticateUser(string login, string password)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            foreach(Personel personel in dc.Personels)
            {
                var saltBytes = Convert.FromBase64String(personel.password_salt);
                var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
                if(Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == personel.password_hash)
                {
                    return personel.role;
                }
            }
            return "";
        }
    }
}
