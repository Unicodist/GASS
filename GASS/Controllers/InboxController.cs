﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GASS.Controllers
{
    public class InboxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
