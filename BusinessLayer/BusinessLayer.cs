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
                Unique = false
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
                Unique = false
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

        public static DataTable GetClientsDataTable()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Id",
                ReadOnly = true,
                Unique = false
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
                Unique = false
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

            var query = from personel in dc.Personels
                        where personel.role == "CLIENT"
                        select personel;

            foreach (Personel personel in query)
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

        public static bool AddPersonel(Personel personel)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.Personels.InsertOnSubmit(personel);
                dc.SubmitChanges();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public static bool FindPersonel(int id, out Personel personel)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryPersonel in dc.Personels
                        where queryPersonel.id_pers == id
                        select queryPersonel;

            if(query.Count() == 1)
            {
                personel = query.First();
                return true;
            }
            else
            {
                personel = null;
                return false;
            }
        }

        public static bool DeletePersonel(int id)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryPersonel in dc.Personels
                        where queryPersonel.id_pers == id
                        select queryPersonel;

            if(query.Count() == 1)
            {
                dc.Personels.DeleteOnSubmit(query.First());
                dc.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static class SelectUserFacade
    {
        public static DataTable GetUsersDataTable(string firstName, string lastName)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Id",
                ReadOnly = true,
                Unique = false
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

            IQueryable<Personel> query;
            if (!firstName.Equals("") && !lastName.Equals(""))
            {
                query = from personelQuery in dc.Personels
                        where personelQuery.fname == firstName
                        && personelQuery.lname == lastName
                        select personelQuery;
            }
            else if (firstName.Equals("") && !lastName.Equals(""))
            {
                query = from personelQuery in dc.Personels
                        where personelQuery.lname == lastName
                        select personelQuery;
            }
            else if (!firstName.Equals("") && lastName.Equals(""))
            {
                query = from personelQuery in dc.Personels
                        where personelQuery.fname == firstName
                        select personelQuery;
            }
            else
            {
                return table;
            }

            foreach (Personel personel in query)
            {
                DataRow row = table.NewRow();
                row["Id"] = personel.id_pers;
                row["First name"] = personel.fname;
                row["Last name"] = personel.lname;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable GetClientsDataTable(string firstName, string lastName)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Id",
                ReadOnly = true,
                Unique = false
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
                Unique = false
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

            var query = from personel in dc.Personels
                        where personel.role == "CLIENT"
                        select personel;

            if(!firstName.Equals(String.Empty))
            {
                query = from personel in dc.Personels
                        where personel.fname == firstName
                        select personel;
            }

            if (!lastName.Equals(String.Empty))
            {
                query = from personel in dc.Personels
                        where personel.lname == lastName
                        select personel;
            }

            foreach (Personel personel in query)
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

    public static class ActivitiesFacade
    {
        public static DataTable GetActivitiesDataTable(int activityId, int requestId, int personelId, string status, string activityType)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;

            /*Request request = new Request()
            {
                nr_obj = 1,
                id_pers = 23,
                descr = "Chce zrobic kupe",
                result = "VERY DONE",
                status = "TBD",
                dt_reg = DateTime.Now,
                dt_fin_cancel = DateTime.Now
            };
            dc.Requests.InsertOnSubmit(request);
            dc.SubmitChanges();

            Activity newActivity = new Activity()
            {
                id_req = 1,
                act_type = "LOL",
                id_pers = 24,
                seq_no = 1,
                descr = "LOLOLOL",
                result = "TROLOLOL",
                status = "NOT RDY",
                dt_reg = DateTime.Now,
                dt_fin_cancel = DateTime.Now
            };
            dc.Activities.InsertOnSubmit(newActivity);
            dc.SubmitChanges();*/

            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Id",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Request Id",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Type",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Personel Id",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Sequence no",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Description",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Result",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Status",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                ColumnName = "Opening date",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                ColumnName = "Closing date",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            var query = from activityQuery in dc.Activities
                        select activityQuery;
            if (activityId > 0)
            {
                query = from activityQuery in dc.Activities
                        where activityQuery.id_act == activityId
                        select activityQuery;
            }
            if (requestId > 0)
            {
                query = from activityQuery in dc.Activities
                        where activityQuery.id_req == requestId
                        select activityQuery;
            }
            if (activityId > 0)
            {
                query = from activityQuery in dc.Activities
                        where activityQuery.id_pers == personelId
                        select activityQuery;
            }
            if (!status.Equals(""))
            {
                query = from activityQuery in dc.Activities
                        where activityQuery.status == status
                        select activityQuery;
            }
            if (!activityType.Equals(""))
            {
                query = from activityQuery in dc.Activities
                        where activityQuery.act_type == activityType
                        select activityQuery;
            }

            foreach (Activity activity in query)
            {
                DataRow row = table.NewRow();
                row["Id"] = activity.id_act;
                row["Request Id"] = activity.id_req;
                row["Type"] = activity.act_type;
                row["Personel Id"] = activity.id_pers;
                row["Sequence no"] = activity.seq_no;
                row["Description"] = activity.descr;
                row["Result"] = activity.result;
                row["Status"] = activity.status;
                row["Opening date"] = activity.dt_reg;
                row["Closing date"] = activity.dt_fin_cancel;
                table.Rows.Add(row);
            }
            return table;
        }
    }

    public static class RequestsFacade
    {
        public static bool FindRequest(int id, out Request request)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryRequest in dc.Requests
                        where queryRequest.id_req == id
                        select queryRequest;

            if (query.Count() == 1)
            {
                request = query.First();
                return true;
            }
            else
            {
                request = null;
                return false;
            }
        }

        public static DataTable GetRequestsDataTable(int id, int objectNumber, int personelId, string result, string status)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;

            /*Request request = new Request()
            {
                nr_obj = 1,
                id_pers = 23,
                descr = "Chce zrobic kupe",
                result = "VERY DONE",
                status = "TBD",
                dt_reg = DateTime.Now,
                dt_fin_cancel = DateTime.Now
            };
            dc.Requests.InsertOnSubmit(request);
            dc.SubmitChanges();

            Activity newActivity = new Activity()
            {
                id_req = 1,
                act_type = "LOL",
                id_pers = 24,
                seq_no = 1,
                descr = "LOLOLOL",
                result = "TROLOLOL",
                status = "NOT RDY",
                dt_reg = DateTime.Now,
                dt_fin_cancel = DateTime.Now
            };
            dc.Activities.InsertOnSubmit(newActivity);
            dc.SubmitChanges();*/

            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Id",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Object number",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Personel id",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Description",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Result",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Status",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                ColumnName = "Opening date",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                ColumnName = "Closing date",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            var query = from requestQuery in dc.Requests
                        select requestQuery;
            if (id > 0)
            {
                query = from requestQuery in dc.Requests
                        where requestQuery.id_req == id
                        select requestQuery;
            }
            if (objectNumber > 0)
            {
                query = from requestQuery in dc.Requests
                        where requestQuery.id_req == id
                        select requestQuery;
            }
            if (personelId > 0)
            {
                query = from requestQuery in dc.Requests
                        where requestQuery.id_pers == personelId
                        select requestQuery;
            }
            if (!result.Equals(""))
            {
                query = from requestQuery in dc.Requests
                        where requestQuery.result == result
                        select requestQuery;
            }
            if(!status.Equals(""))
            {
                query = from requestQuery in dc.Requests
                        where requestQuery.status == status
                        select requestQuery;
            }

            foreach (Request request in query)
            {
                DataRow row = table.NewRow();
                row["Id"] = request.id_req;
                row["Object number"] = request.nr_obj;
                row["Personel id"] = request.id_pers;
                row["Description"] = request.descr;
                row["Result"] = request.result;
                row["Status"] = request.status;
                row["Opening date"] = request.dt_reg;
                row["Closing date"] = request.dt_fin_cancel;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
