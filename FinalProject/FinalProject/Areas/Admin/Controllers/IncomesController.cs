﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IncomesController : Controller
    {
        public IActionResult Index()
        {  
            
            return View();

        }
    }
}
