using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Branches
    {

        public int Id { get; set; }
         
        public string Name { get; set; }
        //public string Doctors { get; set; }
        public List<Doctors> Doctors { get; set; }

        public bool IsDeactive { get; set; }

        [NotMapped]

        public IFormFile Photo { get; set; }

    

    }
}

