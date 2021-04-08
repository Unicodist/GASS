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
        private readonly IHostingEnvironment hostingEnvironment;

        public AssetsController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
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
            string unFileName = null;
            string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "UserData","assetFiles");
            unFileName = "GB_"+Guid.NewGuid().ToString()+"_"+fileInfo.assetFile.FileName;
            string filePath = Path.Combine(uploadFolder, unFileName);
            fileInfo.assetFile.CopyTo(new FileStream(filePath, FileMode.Create));
            
            IFormFile file = fileInfo.assetFile;
            return Content(Convert.ToInt32(file.Length)/1024 + "KB");
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