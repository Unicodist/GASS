using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Mvc;

namespace GASS.Controllers
{
    public class TestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UploadAsset(AssetUploadViewModel ass)
        {
            ViewBag.ass = ass;
            ViewData["filename"] = ass.assetFile.FileName;
            ViewData["filesize"] = ass.assetFile.Length;
            return View();
        }
    }
}
