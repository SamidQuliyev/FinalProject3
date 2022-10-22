using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PatientsController : Controller
    {
        
            private readonly AppDbContext _db;

        public PatientsController(AppDbContext db)
            {
                _db = db;
            }
            public IActionResult Index()
            {
                List<Patients> patients = _db.Patients.Include(x=>x.PatientNumber).ToList();
                return View(patients);


            }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patients Patients)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Patients.AnyAsync(s => s.Name == Patients.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Patients is already exist");
                return View();
            }
            await _db.Patients.AddAsync(Patients);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return Ok();
            }

            return View(dbPatients);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return Ok();
            }

            return View(dbPatients);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, Patients Patients)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return Ok();
            }
            bool isExist = await _db.Patients.AnyAsync(s => s.Name == Patients.Name && s.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Patients is already exist");
                return View();
            }
            dbPatients.Name = Patients.Name;
            dbPatients.PatientNumber = Patients.PatientNumber;
            dbPatients.Doctors = Patients.Doctors;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return Ok();
            }
            if (dbPatients.IsDeactive)
            {
                dbPatients.IsDeactive = false;
            }
            else
            {
                dbPatients.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

