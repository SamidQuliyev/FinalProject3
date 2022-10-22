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
    public class WorkersController : Controller
    {
        
          private readonly AppDbContext _db;

        public WorkersController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Workers> workers = _db.Workers.Include(x => x.Duties).ToList();
            return View(workers);
        }
    }
}
            
