using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GASS.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(String q)
        {
            return View();
        }
    }
}
