using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class DoctorsPatients
    {
        public int Id { get; set; }
        public int DoctorsId { get; set; }
        public Doctors Doctors { get; set; }
        public int PatientsId { get; set; }
        public Patients Patients { get; set; }

    }
}
