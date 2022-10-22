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
    public class AchievementsController : Controller
    {
        private readonly AppDbContext _db;

        public AchievementsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Achievements> achievements =_db.Achievements.ToList();
            return View(achievements);


        }
    }
}
