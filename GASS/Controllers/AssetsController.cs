using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GASS.Controllers
{
    public class AssetsController : Controller
    {
        GASSDBContext dal = new GASSDBContext();
        private readonly IWebHostEnvironment hostingEnvironment;

        public AssetsController(IWebHostEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Upload()
        {
            if (HttpContext.Session.GetString("Logged") == null) return RedirectToAction("Index", "Login");
            List<CategoryModel> categories = dal.category.ToList();
            ViewBag.game_categories = categories;
            return View();
        }
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
            if (fileInfo.Equals(null)) return RedirectToAction("Index", "Home");
            string unFileName = null;
            string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "UserData","assetFiles");
            unFileName = "GB_"+Guid.NewGuid().ToString()+"_"+fileInfo.assetFile.FileName;
            string filePath = Path.Combine(uploadFolder, unFileName);
            //fileInfo.assetFile.CopyTo(new FileStream(filePath, FileMode.Create));

            AssetModel dbAsset = new AssetModel{
                title = fileInfo.title,
                description = fileInfo.description,
                price = fileInfo.priceTag,
                down_count = 0,
                rating = 0,
                user = JsonConvert.DeserializeObject<UserModel>(HttpContext.Session.GetString("User")).id,
                filePath = filePath,
            };

            dal.assets.Add(dbAsset);
            dal.SaveChanges();
            
            IFormFile file = fileInfo.assetFile;
            return Content(fileInfo.priceTag.ToString());
        }
        public async Task<String> UploadCat(string title, string description)
        {
            if (title.Equals(String.Empty)) return "error";
            try
            {
                if (dal.category.Where(x => x.category_name.Equals(title)).Count() > 0) return "error";
                CategoryModel newcat = new CategoryModel
                {
                    category_name = title,
                    category_description = description
                };
                dal.category.Add(newcat);
                dal.SaveChanges();
                CategoryModel retCat = dal.category.SingleOrDefault(x => x.category_name.Equals(title));
                return JsonConvert.SerializeObject(retCat);
            } catch (Exception)
            {
                return "error";
            }
        }
        public async Task<string> getCategories(string name)
        {
            List<CategoryModel> categories = dal.category.Where(x => x.category_name.Contains(name)).ToList();
            return JsonConvert.SerializeObject(categories);
        }
    }
}