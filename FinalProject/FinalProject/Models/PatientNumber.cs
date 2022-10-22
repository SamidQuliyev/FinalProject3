using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class PatientNumber
    {
        public int Id { get; set; }

        public int Number { get; set; }
        public bool IsDeactive { get; set; }
        public Patients Patients { get; set; }
    }
}
