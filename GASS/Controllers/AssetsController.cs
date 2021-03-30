using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GASS.Controllers
{
    public class AssetsController : Controller
    {
        GASSDBContext dal = new GASSDBContext();
        
        public IActionResult Category(string id="new")
        {

            return View();
        }
        public IActionResult Browse(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index", "Home");
            AssetModel asset = dal.assets.Find(id);
            ViewBag.asset = asset;
            return View();
        }
        public IActionResult UploadAssetAction(AssetUploadViewModel fileInfo)
        {
            IFormFile file = fileInfo.assetFile;
            return Content(Convert.ToInt32(file.Length)/1024 + "KB");
        }
        public String UploadCat(string title, string description)
        {
            if (title.Equals(String.Empty) || description.Equals(String.Empty)) return "error";
            try
            {
                CategoryModel newcat = new CategoryModel
                {
                    category_name = title,
                    category_description = description
                };
                dal.category.Add(newcat);
                dal.SaveChanges();
                return "good";
            } catch (Exception)
            {
                return "error";
            }
        }
    }
}
