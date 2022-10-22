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
    public class CampaignsController : Controller
    {
        private readonly AppDbContext _db;

        public CampaignsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Campaigns> campaigns = _db.Campaigns.ToList();
            return View(campaigns);


        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Campaigns Campaigns)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Campaigns.AnyAsync(s => s.Name == Campaigns.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Campaigns is already exist");
                return View();
            }
            await _db.Campaigns.AddAsync(Campaigns);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Campaigns dbCampaigns = await _db.Campaigns.FirstOrDefaultAsync(s => s.Id == id);
            if (dbCampaigns == null)
            {
                return Ok();
            }

            return View(dbCampaigns);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Campaigns dbCampaigns = await _db.Campaigns.FirstOrDefaultAsync(s => s.Id == id);
            if (dbCampaigns == null)
            {
                return Ok();
            }

            return View(dbCampaigns);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, Campaigns Campaigns)
        {
            if (id == null)
            {
                return NotFound();
            }

            Campaigns dbCampaigns = await _db.Campaigns.FirstOrDefaultAsync(s => s.Id == id);
            if (dbCampaigns == null)
            {
                return Ok();
            }
            bool isExist = await _db.Campaigns.AnyAsync(s => s.Name == Campaigns.Name && s.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Campaigns is already exist");
                return View();
            }
            dbCampaigns.Name = Campaigns.Name;
            dbCampaigns.Information = Campaigns.Information;
     

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Campaigns dbCampaigns = await _db.Campaigns.FirstOrDefaultAsync(s => s.Id == id);
            if (dbCampaigns == null)
            {
                return Ok();
            }
            if (dbCampaigns.IsDeactive)
            {
                dbCampaigns.IsDeactive = false;
            }
            else
            {
                dbCampaigns.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

