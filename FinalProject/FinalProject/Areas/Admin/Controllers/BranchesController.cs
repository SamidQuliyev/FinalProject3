using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;

        public BranchesController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Branches> branches = _db.Branches.ToList();
            return View(branches);
          

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Branches Branches)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Branches.AnyAsync(s => s.Name == Branches.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Branches is already exist");
                return View();
            }
            await _db.Branches.AddAsync(Branches);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branches dbBranches = await _db.Branches.FirstOrDefaultAsync(s => s.Id == id);
            if (dbBranches == null)
            {
                return Ok();
            }

            return View(dbBranches);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branches dbBranches = await _db.Branches.FirstOrDefaultAsync(s => s.Id == id);
            if (dbBranches == null)
            {
                return Ok();
            }

            return View(dbBranches);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, Branches Branches)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branches dbBranches = await _db.Branches.FirstOrDefaultAsync(s => s.Id == id);
            if (dbBranches == null)
            {
                return Ok();
            }
            bool isExist = await _db.Branches.AnyAsync(s => s.Name == Branches.Name && s.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Branches is already exist");
                return View();
            }
            dbBranches.Name = Branches.Name;
          


            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branches dbBranches = await _db.Branches.FirstOrDefaultAsync(s => s.Id == id);
            if (dbBranches == null)
            {
                return Ok();
            }
            if (dbBranches.IsDeactive)
            {
                dbBranches.IsDeactive = false;
            }
            else
            {
                dbBranches.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
