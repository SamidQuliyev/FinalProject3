using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Branches> Branches { get; set; }
   
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Laboratories> Laboratories { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<Duties> Duties { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Achievements> Achievements { get; set; }
        public DbSet<Equipments> Equipments { get; set; }
        public DbSet<PatientNumber> PatientNumbers { get; set; }
        public DbSet<DoctorsPatients> DoctorsPatients { get; set; }

    }
}
