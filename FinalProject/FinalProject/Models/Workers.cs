using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Workers
    {
        public int Id { get; set; }

        public string Image { get; set; }
        public string FullName { get; set; }

        public string Salary { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public Duties Duties { get; set; }

        public int DutiesId { get; set; }
        public bool IsDeactive { get; set; }
        [NotMapped]

        public IFormFile Photo { get; set; }


    }
}
