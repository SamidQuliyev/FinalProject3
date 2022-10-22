using EduHome.Helpers;
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
    public class PartnersController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public PartnersController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Partners> partners = _db.Partners.ToList();
            return View(partners);


        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Partners Partners)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Partners.AnyAsync(s => s.Name == Partners.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Partners is already exist");
                return View();
            }
            if (Partners.Photo == null)
            {
                ModelState.AddModelError("Photo", "Image can not be null");
                return View();
            }
            if (!Partners.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select image");
                return View();
            }
            if (Partners.Photo.OlderOneMb())
            {
                ModelState.AddModelError("Photo", "Image max 3mb");
                return View();
            }
            string path = Path.Combine(_env.WebRootPath, "img", "Partners");
            Partners.Image = await Partners.Photo.SaveFileAsync(path);
            await _db.Partners.AddAsync(Partners);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Partners dbPartners = await _db.Partners.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPartners == null)
            {
                return Ok();
            }

            return View(dbPartners);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Partners dbPartners = await _db.Partners.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPartners == null)
            {
                return Ok();
            }

            return View(dbPartners);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, Partners Partners)
        {
            if (id == null)
            {
                return NotFound();
            }

            Partners dbPartners = await _db.Partners.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPartners == null)
            {
                return Ok();
            }
            bool isExist = await _db.Partners.AnyAsync(s => s.Name == Partners.Name && s.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Partners is already exist");
                return View();
            }
            if (Partners.Photo != null)
            {
                if (!Partners.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select image");
                    return View(dbPartners);
                }
                if (Partners.Photo.OlderOneMb())
                {
                    ModelState.AddModelError("Photo", "Image max 3mb");
                    return View(dbPartners);
                }
                string path = Path.Combine(_env.WebRootPath, "img", "Partners");

                if (System.IO.File.Exists(Path.Combine(path, dbPartners.Image)))
                {
                    System.IO.File.Delete(Path.Combine(path, dbPartners.Image));
                }
                dbPartners.Image = await Partners.Photo.SaveFileAsync(path);
            }
            dbPartners.Name = Partners.Name;
            dbPartners.Image = Partners.Image;
            dbPartners.Information = Partners.Information;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Partners dbPartners = await _db.Partners.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPartners == null)
            {
                return Ok();
            }
            if (dbPartners.IsDeactive)
            {
                dbPartners.IsDeactive = false;
            }
            else
            {
                dbPartners.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
