using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABS3.Models
{
    public class DoctorPatient
    {
        public DoctorPatient ()
        {
            Patients = new List<Patient> ();
        }      
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}