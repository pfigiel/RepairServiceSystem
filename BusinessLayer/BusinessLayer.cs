using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
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
            var query = (from personel in dc.Personels
                         where personel.login == login
                         select personel).SingleOrDefault();
            if (query == null) query = new Personel { role = "NONE" };
            else
            {
                var saltBytes = Convert.FromBase64String(query.password_salt);
                var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
                if (Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) != query.password_hash)
                {
                    query = new Personel { role = "NONE" };
                }
            }
            return query;
        }
    }

    public static class AdminFacade
    {
        public static IQueryable GetPersonelDataTable()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from personel in dc.Personels
                        select new
                        {
                            ID = personel.id_pers,
                            Login = personel.login,
                            First_name = personel.fname,
                            Last_name = personel.lname,
                            Role = personel.role
                        };
            return query;
        }

        public static IQueryable GetClientsDataTable()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = from client in dc.Clients
                        select new
                        {
                            ID = client.id_cli,
                            First_name = client.fname,
                            Last_name = client.lname,
                            Company_name = client.name,
                            Telephone = client.telephone
                        };
            return query;
        }

        public static bool AddPersonel(Personel personel)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            try
            {
                dc.Personels.InsertOnSubmit(personel);
                dc.SubmitChanges();
            }
            catch (Exception e) { return false; }
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

        public static void UpdateUser(Personel personelToUpdate)
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
            else return false;
        }
    }

    public static class ActivitiesFacade
    {
        public static IQueryable GetActivitiesDataTable(int activityId, int requestId, int personelId, string status, string activityType)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var query = from activityQuery in dc.Activities
                        select activityQuery;

            if (activityId > 0)
            {
                query = from activityQuery in query
                        where activityQuery.id_act == activityId
                        select activityQuery;
            }
            if (requestId > 0)
            {
                query = from activityQuery in query
                        where activityQuery.id_req == requestId
                        select activityQuery;
            }
            if (activityId > 0)
            {
                query = from activityQuery in query
                        where activityQuery.id_act == activityId
                        select activityQuery;
            }
            if (personelId > 0)
            {
                query = from activityQuery in query
                        where activityQuery.id_pers == personelId
                        select activityQuery;
            }
            if (!status.Equals(""))
            {
                query = from activityQuery in query
                        where activityQuery.status == status
                        select activityQuery;
            }
            if (!activityType.Equals(""))
            {
                query = from activityQuery in query
                        where activityQuery.act_type == activityType
                        select activityQuery;
            }

            return from activity in query
                   select new
                   {
                       ID = activity.id_act,
                       Request_ID = activity.id_req,
                       Type = activity.act_type,
                       Personel_ID = activity.id_pers,
                       Sequence_number = activity.seq_no,
                       Description = activity.descr,
                       Status = activity.status,
                       Opening_date = activity.dt_reg,
                       Closing_date = activity.dt_fin_cancel
                   };
        }

        public static IQueryable GetActivitiesForWorker(Personel personel)
        {
            return GetActivitiesDataTable(0, 0, personel.id_pers, "", "");
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
            catch (Exception e) { return false; }

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
            catch (Exception ex) { return false; }
        }

        public static IQueryable GetActivities()
        {
            return GetActivitiesDataTable(0, 0, 0, "", "");
        }
    }

    public static class RequestsFacade
    {
        public static IQueryable GetRequests()
        {
            return GetRequestsDataTable(0, 0, 0, "", "");
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
            else return false;
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
            catch (Exception ex) { return false; }
        }

        public static bool AddRequest(Request request)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            try
            {
                dc.Requests.InsertOnSubmit(request);
                dc.SubmitChanges();
            }
            catch (Exception e) { return false; }

            return true;
        }
        public static IQueryable GetRequestsDataTable(int id, int objectNumber, int personelId, string result, string status)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var query = from requestQuery in dc.Requests
                        select requestQuery;

            if (id > 0)
            {
                query = from requestQuery in query
                        where requestQuery.id_req == id
                        select requestQuery;
            }
            if (objectNumber > 0)
            {
                query = from requestQuery in query
                        where requestQuery.nr_obj == objectNumber
                        select requestQuery;
            }
            if (personelId > 0)
            {
                query = from requestQuery in query
                        where requestQuery.id_pers == personelId
                        select requestQuery;
            }
            if (!result.Equals(""))
            {
                query = from requestQuery in query
                        where requestQuery.result.Contains(result)
                        select requestQuery;
            }
            if (!status.Equals(""))
            {
                query = from requestQuery in query
                        where requestQuery.status == status
                        select requestQuery;
            }

            return from request in query
                   select new
                   {
                       ID = request.id_req,
                       Object_number = request.nr_obj,
                       Personel_ID = request.id_pers,
                       Description = request.descr,
                       Result = request.result,
                       Status = request.status,
                       Opening_date = request.dt_reg,
                       Closing_date = request.dt_fin_cancel
                   };
        }
    }

    public static class ObjectFacade
    {
        public static IQueryable GetObjectsDataTable(int id, String name, String codeType)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var query = from objectQuery in dc.Objects
                        select objectQuery;

            if (id > 0)
            {
                query = from objectQuery in dc.Objects
                        where objectQuery.id_cli == id
                        select objectQuery;
            }
            if (!codeType.Equals(""))
            {
                query = from objectQuery in dc.Objects
                        where objectQuery.ObjType.code_type.Contains(codeType)
                        select objectQuery;
            }
            if (!name.Equals(""))
            {
                query = from objectQuery in dc.Objects
                        where objectQuery.name.Contains(name)
                        select objectQuery;
            }

            return from obj in dc.Objects
                   select new
                   {
                       Object_number = obj.nr_obj,
                       Name = obj.name,
                       Client_ID = obj.id_cli,
                       Code_type = obj.code_type
                   };
        }

        public static IQueryable GetObjectsDataTable()
        {
            return GetObjectsDataTable(0, "", "");
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
            else return false;
        }

        public static bool DeleteObjectRequests(int nr_obj)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var query = from queryRequest in dc.Requests
                        where queryRequest.nr_obj == nr_obj
                        select queryRequest;

            foreach (Request request in query)
            {
                try
                {
                    dc.Requests.DeleteOnSubmit(request);
                    dc.SubmitChanges();
                }
                catch (Exception ex) { return false; }
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
            catch (Exception e) { return false; }

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
            catch (Exception ex) { return false; }
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
            else return false;
        }
        public static bool AddClient(DataLayer.Client client)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            try
            {
                dc.Clients.InsertOnSubmit(client);
                dc.SubmitChanges();
            }
            catch (Exception e) { return false; }

            return true;
        }
    }

    public static class UsersFacade
    {
        public static IQueryable FindUser(string firstName, string lastName)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var query = from user in dc.Personels
                        select user;

            if (firstName.Any())
            {
                query = from user in query
                        where user.fname == firstName
                        select user;
            }
            if (lastName.Any())
            {
                query = from user in query
                        where user.lname == lastName
                        select user;
            }

            return from user in query
                   select new
                   {
                       ID = user.id_pers,
                       Login = user.login,
                       First_name = user.fname,
                       Last_name = user.lname,
                       Role = user.role
                   };
        }

        public static IQueryable GetClientsDataTable(string firstName, string lastName)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var query = from client in dc.Clients
                        select client;

            if (firstName.Any())
            {
                query = from client in query
                        where client.fname == firstName
                        select client;
            }
            if (lastName.Any())
            {
                query = from client in query
                        where client.lname == lastName
                        select client;
            }

            return from client in query
                   select new
                   {
                       First_name = client.fname,
                       Last_name = client.lname,
                       Company_name = client.name,
                       Telephone = client.telephone
                   };
        }

        public static IQueryable GetUsersByRole(string role)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            return from manager in dc.Personels
                   where manager.role == role
                   select new
                   {
                       ID = manager.id_pers,
                       First_name = manager.fname,
                       Last_name = manager.lname,
                       Login = manager.login,
                       Role = manager.role
                   };
        }
    }

    public static class ActivityTypeFacade
    {
        public static List<string> GetActivityTypeNames()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            List<string> activityTypeNames = new List<string>();

            foreach (ActDict el in dc.ActDicts)
            {
                activityTypeNames.Add(el.act_name);
            }

            return activityTypeNames;
        }

        public static List<string> GetActivityTypes()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            List<string> activityTypeNames = new List<string>();

            foreach (ActDict el in dc.ActDicts) activityTypeNames.Add(el.act_type);

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

            foreach (ObjType el in dc.ObjTypes) objectTypeNames.Add(el.name_type);

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

        public static string GetObjectNameByObjectType(string code_type)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            var query = (from name in dc.ObjTypes
                        where name.code_type == code_type
                        select name).SingleOrDefault();
            return query.name_type;
        }
    }
}