using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


// 
namespace BizzLayer
{


    static public class RegistrationFacade
    {
        public static IQueryable<Patient> GetPatients(Patient searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from el in dc.Patients
                      where
                      (String.IsNullOrEmpty(searchCrit.LastName) || el.LastName.StartsWith(searchCrit.LastName))
                      &&
                      ((searchCrit.IdPatient == 0) || el.IdPatient == searchCrit.IdPatient)
                      // && inne ...
                      select el;
            return res;
        }
        /// <summary>
        /// nie musi być void
        /// </summary>
        /// <param name="pat"></param>
        public static void UpdatePatientData(Patient pat)
        {
            using (DataClassesClinicDataContext dc = new DataClassesClinicDataContext())
            {
                var res = (from el in dc.Patients
                           where el.IdPatient == pat.IdPatient
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.LastName = pat.LastName;
                res.FirstName = pat.FirstName;
                dc.SubmitChanges();

            }

        }

    }

    static public class DoctorFacade
    {
        public static IQueryable GetVisits(Visit searchCrit)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var res = from vis in dc.Visits
                      select
                       new
                       {
                           vis.IdVisit,
                           FirstName = vis.Patient.FirstName,
                           LastName = vis.Patient.LastName,
                           vis.Description,
                           vis.Diagnosis
                       };
            return res;
        }
        public static void UpdateVisitData(Visit vis)
        {
            return;
        }
    }

}