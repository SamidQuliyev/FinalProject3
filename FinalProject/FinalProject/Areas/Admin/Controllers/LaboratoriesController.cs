using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LaboratoriesController : Controller
    {
        private readonly AppDbContext _db;

        public LaboratoriesController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Laboratories > laboratories = _db.Laboratories.ToList();
            return View(laboratories);
        }
    }
}
