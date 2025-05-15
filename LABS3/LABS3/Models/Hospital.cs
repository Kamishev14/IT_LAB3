using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LABS3.Models
{
    public class Hospital
    {
        public Hospital()
        {
            Doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Hospital Address")]
        public string Address { get; set; }
        public string ImageURL { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}