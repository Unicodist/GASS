using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Mvc;

namespace GASS.Controllers
{
    public class SearchController : Controller
    {
        GASSDBContext dal = new GASSDBContext();
        public IActionResult Index(string q)
        {
            List<AssetModel> assets = dal.assets.ToList();
            ViewBag.assetlist = assets;
            return View();
        }
    }
}
