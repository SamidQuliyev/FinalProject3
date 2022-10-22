using EduHome.Helpers;
using FinalProject;
using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public DoctorsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Doctors> Doctors = _db.Doctors.Include(x=>x.Branches).ToList();
            return View(Doctors);

        }

        public async Task<IActionResult> Detail(int? id)
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctor = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctor == null)
            {
                return BadRequest();
            }

            return View(dbDoctor);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();



            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Doctors Doctors, int? posId)
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (posId == null)
            {
                ModelState.AddModelError("FullName", "Branches");
                return View();
            }
            Branches Branches = await _db.Branches.FirstOrDefaultAsync(x => x.Id == posId);
            if (Branches == null)
            {
                ModelState.AddModelError("FullName", "Branches");
                return View();
            }
            if (Doctors.Photo == null)
            {
                ModelState.AddModelError("Photo", "Image can not be null");
                return View();
            }
            if (!Doctors.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select image");
                return View();
            }
            if (Doctors.Photo.OlderOneMb())
            {
                ModelState.AddModelError("Photo", "Image max 3mb");
                return View();
            }
            string path = Path.Combine(_env.WebRootPath, "img", "Doctors");
            Doctors.Image = await Doctors.Photo.SaveFileAsync(path);

            Doctors.BranchesId = (int)posId;

            await _db.Doctors.AddAsync(Doctors);
            await _db.SaveChangesAsync();



            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)

        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctors = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctors == null)
            {
                return Ok();
            }

            return View(dbDoctors);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Doctors Doctors, int? posId)
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctors = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctors == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dbDoctors);
            }
            if (posId == null)
            {
                ModelState.AddModelError("FullName", "Branches");
                return View();
            }
            Branches Branches = await _db.Branches.FirstOrDefaultAsync(x => x.Id == posId);
            if (Branches == null)
            {
                ModelState.AddModelError("FullName", "Branches");
                return View();
            }
            if (Doctors.Photo != null)
            {
                if (!Doctors.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select image");
                    return View(dbDoctors);
                }
                if (Doctors.Photo.OlderOneMb())
                {
                    ModelState.AddModelError("Photo", "Image max 3mb");
                    return View(dbDoctors);
                }
                string path = Path.Combine(_env.WebRootPath, "img", "Doctors");

                if (System.IO.File.Exists(Path.Combine(path, dbDoctors.Image)))
                {
                    System.IO.File.Delete(Path.Combine(path, dbDoctors.Image));
                }
                dbDoctors.Image = await Doctors.Photo.SaveFileAsync(path);
            }

            dbDoctors.FullName = Doctors.FullName;

            Doctors.BranchesId = (int)posId;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctors = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctors == null)
            {
                return Ok();
            }
            if (dbDoctors.IsDeactive)
            {
                dbDoctors.IsDeactive = false;
            }
            else
            {
                dbDoctors.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
 
}
