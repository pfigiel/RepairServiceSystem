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

        public static Personel AuthenticateUser(string login, string password)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            foreach (Personel personel in dc.Personels)
            {
                var saltBytes = Convert.FromBase64String(personel.password_salt);
                var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
                if (Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == personel.password_hash)
                {
                    return personel;
                }
            }
            return new Personel { role = "NONE"};
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
                ColumnName = " name",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "First Name",
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
                ColumnName = "Telephone",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            foreach (Client client in dc.Clients)
            {
                DataRow row = table.NewRow();
                row["Id"] = client.id_cli;
                row[" name"] = client.name;
                row["First Name"] = client.fname;
                row["Last name"] = client.lname;
                row["Telephone"] = client.telephone;
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
            catch (Exception e)
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

            if (query.Count() == 1)
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

        public static void updateUser(Personel personelToUpdate)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryPersonel in dc.Personels
                        where queryPersonel.id_pers == personelToUpdate.id_pers
                        select queryPersonel;

            if (query.Count() == 1)
            {
                Personel personel = query.First();
                personel.fname = personelToUpdate.fname;
                personel.lname = personelToUpdate.lname;
                personel.login = personelToUpdate.login;
                personel.password_hash = personelToUpdate.password_hash;
                personel.password_salt = personelToUpdate.password_salt;
                dc.SubmitChanges();
            }
        }

        public static bool DeletePersonel(int id)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryPersonel in dc.Personels
                        where queryPersonel.id_pers == id
                        select queryPersonel;

            if (query.Count() == 1)
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
                ColumnName = "Name",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Telephone",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            var query = from personel in dc.Clients
                        select personel;

            if (!firstName.Equals(String.Empty))
            {
                query = from personel in dc.Clients
                        where personel.fname == firstName
                        select personel;
            }

            if (!lastName.Equals(String.Empty))
            {
                query = from personel in dc.Clients
                        where personel.lname == lastName
                        select personel;
            }

            foreach (Client personel in query)
            {
                DataRow row = table.NewRow();
                row["Id"] = personel.id_cli;
                row["First name"] = personel.fname;
                row["Last name"] = personel.lname;
                row["Name"] = personel.name;
                row["Telephone"] = personel.telephone;
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
                if (activity.status.ToString().Contains("INPR"))
                {
                    row["Status"] = "IN PROGRESS";
                }
                else if (activity.status.ToString().Contains("FINI"))
                {
                    row["Status"] = "FINISHED";
                }
                else if (activity.status.ToString().Contains("CANC"))
                {
                    row["Status"] = "CANCELLED";
                }
                else if (activity.status.ToString().Contains("OPEN"))
                {
                    row["Status"] = "OPEN";
                }
                row["Opening date"] = activity.dt_reg;
                row["Closing date"] = activity.dt_fin_cancel;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable GetActivitiesForWorker(Personel personel)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from activityQuery in dc.Activities
                        where activityQuery.id_pers == personel.id_pers
                        select activityQuery;

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
                if (activity.status.ToString().Contains("INPR"))
                {
                    row["Status"] = "IN PROGRESS";
                }
                else if (activity.status.ToString().Contains("FINI"))
                {
                    row["Status"] = "FINISHED";
                }
                else if (activity.status.ToString().Contains("CANC"))
                {
                    row["Status"] = "CANCELLED";
                }
                else if (activity.status.ToString().Contains("OPEN"))
                {
                    row["Status"] = "OPEN";
                }
                row["Opening date"] = activity.dt_reg;
                row["Closing date"] = activity.dt_fin_cancel;
                table.Rows.Add(row);
            }
            return table;

        }

        public static bool FindActivity(int id, out Activity activity)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from activityQuery in dc.Activities
                        where activityQuery.id_act == id
                        select activityQuery;
            if (query.Count() == 1)
            {
                activity = query.First();
                return true;
            }
            else
            {
                activity = null;
                return false;
            }
        }

        public static bool AddActivity(Activity activity)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.Activities.InsertOnSubmit(activity);
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static bool UpdateActivity(Activity activity)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataLayer.Activity toUPdate = (from queryActivity in dc.Activities
                                         where queryActivity.id_act == activity.id_act
                                         select queryActivity).SingleOrDefault();
            toUPdate.seq_no = activity.seq_no;
            toUPdate.status = activity.status;
            toUPdate.result = activity.result;
            toUPdate.descr = activity.descr;
            toUPdate.id_pers = activity.id_pers;
            toUPdate.act_type = activity.act_type;
            toUPdate.dt_fin_cancel = activity.dt_fin_cancel;
            toUPdate.dt_reg = activity.dt_reg;
            try
            {
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable GetActivitiesByRequestId(int id)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryActivity in dc.Activities
                        where queryActivity.id_req == id
                        select queryActivity;
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

        public static DataTable GetActivities()
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
            foreach (DataLayer.Activity activity in dc.Activities)
            {
                DataRow row = table.NewRow();
                row["Id"] = activity.id_act;
                row["Request Id"] = activity.id_req;
                row["Type"] = activity.act_type;
                row["Personel Id"] = activity.id_pers;
                row["Sequence no"] = activity.seq_no;
                row["Description"] = activity.descr;
                row["Result"] = activity.result;
                if(activity.status.ToString().Contains("INPR"))
                {
                    row["Status"] = "IN PROGRESS";
                }
                else if(activity.status.ToString().Contains("FINI"))
                {
                    row["Status"] = "FINISHED";
                }
                else if(activity.status.ToString().Contains("CANC"))
                {
                    row["Status"] = "CANCELLED";
                }
                else if(activity.status.ToString().Contains("OPEN"))
                {
                    row["Status"] = "OPEN";
                }

                row["Opening date"] = activity.dt_reg;
                row["Closing date"] = activity.dt_fin_cancel;
                table.Rows.Add(row);
            }
            return table;
        }
    }

    public static class RequestsFacade
    {
        public static DataTable GetRequests()
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
            foreach (Request request in dc.Requests)
            {
                DataRow row = table.NewRow();
                row["Id"] = request.id_req;
                row["Object number"] = request.nr_obj;
                row["Personel id"] = request.id_pers;
                row["Description"] = request.descr;
                row["Result"] = request.result;
                if(request.status == "CANC")
                {
                    row["Status"] = "CANCELLED";
                }
                else if(request.status == "FINI")
                {
                    row["Status"] = "FINISHED";
                }
                else if (request.status == "INPR")
                {
                    row["Status"] = "IN_PROGRESS";
                }
                else
                {
                    row["Status"] = request.status;
                }
                row["Opening date"] = request.dt_reg;
                row["Closing date"] = request.dt_fin_cancel;
                table.Rows.Add(row);
            }
            return table;
        }

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

        public static bool DeleteRequest(int id)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryRequest in dc.Requests
                        where queryRequest.id_req == id
                        select queryRequest;
            if (query.Count() == 1)
            {
                dc.Requests.DeleteOnSubmit(query.First());
                dc.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UpdateRequest(Request request)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataLayer.Request toUPdate = (from queryRequest in dc.Requests
                                           where queryRequest.id_req == request.id_req
                                           select queryRequest).SingleOrDefault();
            toUPdate.status = request.status;
            toUPdate.nr_obj = request.nr_obj;
            toUPdate.id_pers = request.id_pers;
            toUPdate.dt_fin_cancel = request.dt_fin_cancel;
            toUPdate.dt_reg = request.dt_reg;
            toUPdate.result = request.result;
            toUPdate.descr = request.descr;
            try
            {
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool AddRequest(Request request)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.Requests.InsertOnSubmit(request);
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static DataTable GetRequestsDataTable(int id, int objectNumber, int personelId, string result, string status)
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
                        where requestQuery.nr_obj == objectNumber
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
            if (!status.Equals(""))
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
                if (request.status == "CANC")
                {
                    row["Status"] = "CANCELLED";
                }
                else if (request.status == "FINI")
                {
                    row["Status"] = "FINISHED";
                }
                else if (request.status == "INPR")
                {
                    row["Status"] = "IN_PROGRESS";
                }
                else
                {
                    row["Status"] = request.status;
                }
                row["Opening date"] = request.dt_reg;
                row["Closing date"] = request.dt_fin_cancel;
                table.Rows.Add(row);
            }
            return table;
        }
    }

    public static class ObjectFacade
    {
        public static DataTable GetObjectsDataTable()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Number Object",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Name",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Client Id",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Code Type",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            foreach (DataLayer.Object obj in dc.Objects)
            {
                DataRow row = table.NewRow();
                row["Number Object"] = obj.nr_obj;
                row["Name"] = obj.name;
                row["Client Id"] = obj.id_cli;
                row["code Type"] = obj.ObjType.code_type;
                table.Rows.Add(row);
            }
            return table;
        }
        public static bool DeleteObject(int id)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryObject in dc.Objects
                        where queryObject.nr_obj == id
                        select queryObject;
            if (query.Count() == 1)
            {
                dc.Objects.DeleteOnSubmit(query.First());
                dc.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DeleteObjectRequests(int nr_obj)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryRequest in dc.Requests
                        where queryRequest.nr_obj == nr_obj
                        select queryRequest;
            foreach(Request request in query)
            {
                try
                {
                    dc.Requests.DeleteOnSubmit(request);
                    dc.SubmitChanges();
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool AddObject(DataLayer.Object obj)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.Objects.InsertOnSubmit(obj);
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static bool UpdateObject(DataLayer.Object obj)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataLayer.Object toUPdate = (from queryObject in dc.Objects
                        where queryObject.nr_obj == obj.nr_obj
                        select queryObject).SingleOrDefault();
            toUPdate.name = obj.name;
            toUPdate.code_type = obj.code_type;
            toUPdate.id_cli = obj.id_cli;
            try
            {
                dc.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public static DataTable GetObjectsDataTable(int id,String name,String codeType)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            DataTable table = new DataTable();
            DataColumn column;
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Number Object",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Name",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Client Id",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Code Type",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            var query = from objectQuery in dc.Objects
                        select objectQuery;
            if (id > 0 )
            {
                query = from objectQuery in dc.Objects
                        where objectQuery.id_cli == id
                        select objectQuery;
            }
            if(!codeType.Equals(""))
            {
                query = from objectQuery in dc.Objects
                        where objectQuery.ObjType.code_type == codeType
                        select objectQuery;
            }
            if(!name.Equals(""))
            {
                query = from objectQuery in dc.Objects
                        where objectQuery.name == name
                        select objectQuery;
            }
            foreach (DataLayer.Object obj in query)
            {
                DataRow row = table.NewRow();
                row["Number Object"] = obj.nr_obj;
                row["Name"] = obj.name;
                row["Client Id"] = obj.id_cli;
                row["code Type"] = obj.ObjType.code_type;
                table.Rows.Add(row);
            }
            return table;

        }
        public static bool FindObject(int nr_obj, out DataLayer.Object obj)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryObject in dc.Objects
                        where queryObject.nr_obj == nr_obj
                        select queryObject;

            if (query.Count() == 1)
            {
                obj = query.First();
                return true;
            }
            else
            {
                obj = null;
                return false;
            }
        }
    }
    public static class ClientFacade
    {
        public static bool DeleteClient(int id)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from queryClient in dc.Clients
                        where queryClient.id_cli == id
                        select queryClient;
            if (query.Count() == 1)
            {
                dc.Clients.DeleteOnSubmit(query.First());
                dc.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AddClient(DataLayer.Client client)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.Clients.InsertOnSubmit(client);
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }

    public static class UsersFacade
    {
        public static DataTable GetManagers()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from Manager in dc.Personels
                        where Manager.role == "MANAGER"
                        select Manager;
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

        public static DataTable GetWorkers()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from Manager in dc.Personels
                        where Manager.role == "WORKER"
                        select Manager;
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

    public static class ActivityTypeFacade
    {
        public static List<string> GetActivityTypes()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            List<string> activityTypeNames = new List<string>();
            foreach(ActDict el in dc.ActDicts)
            {
                activityTypeNames.Add(el.act_name);
            }
            return activityTypeNames;
        }

        public static string GetActivityTypeByActivityName(string activityName)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from type in dc.ActDicts
                        where type.act_name == activityName
                        select type;
            if (query.Count() == 1) return query.First().act_type;
            else return string.Empty;
        }
    }

    public static class ObjectTypeFacade
    {
        public static List<string> GetObjectTypes()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            List<string> objectTypeNames = new List<string>();
            foreach (ObjType el in dc.ObjTypes)
            {
                objectTypeNames.Add(el.name_type);
            }
            return objectTypeNames;
        }

        public static string GetObjectTypeByObjectName(string objectName)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from type in dc.ObjTypes
                        where type.name_type == objectName
                        select type;
            if (query.Count() == 1) return query.First().code_type;
            else return string.Empty;
        }
    }
}
