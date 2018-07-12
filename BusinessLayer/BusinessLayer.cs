using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    static public class AccountsFacade
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

    public static class AdminFacade
    {
        public static DataTable GetPersonelDataTable()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Id",
                ReadOnly = true,
                Unique = true
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "First name",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Last name",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Login",
                ReadOnly = true,
                Unique = true
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Role",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            foreach (Personel personel in dc.Personels)
            {
                DataRow row = table.NewRow();
                row["Id"] = personel.id_pers;
                row["First name"] = personel.fname;
                row["Last name"] = personel.lname;
                row["Login"] = personel.login;
                row["Role"] = personel.role;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
