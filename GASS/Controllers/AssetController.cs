using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GASS.Controllers
{
    public class AssetController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Browse(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index", "Home");
            GASSDBContext dal = new GASSDBContext();
            AssetModel asset = dal.assets.Find(id);
            ViewBag.asset = asset;
            return View();
        }
    }
}
