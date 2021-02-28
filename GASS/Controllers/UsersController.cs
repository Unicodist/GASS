using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Mvc;

namespace GASS.Controllers
{
    public class UsersController : Controller
    {
        GASSDBContext dal = new GASSDBContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upload()
        {
            List<CategoryModel> categories = dal.category.ToList();
            ViewBag.game_categories = categories;
            return View();
        }
        public IActionResult UploadAction(AssetUploadViewModel formAsset)
        {
            return View();
        }
    }
}
