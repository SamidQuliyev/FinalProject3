using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Patients
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Doctors { get; set; }
        public PatientNumber PatientNumber { get; set; }
        public int PatientNumberId { get; set; }

        //public List<Doctors> Doctors { get; set; }

        public bool IsDeactive { get; set; }

        [NotMapped]

        public IFormFile Photo { get; set; }
        public List<DoctorsPatients> DoctorsPatients { get; set; }

    }
}
