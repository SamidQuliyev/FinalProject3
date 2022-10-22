using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EquipmentsController : Controller
    {
        private readonly AppDbContext _db;

        public EquipmentsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Equipments> equipments = _db.Equipments.ToList();
            return View(equipments);
        }
    }
    }

