using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LABS3.Models
{
    public class Patient
    {
        public Patient()
        {
            Doctors = new List<Doctor>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        [Display(Name="Patient Code")]
        [MaxLength(5)]
        public string PatientCode { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}