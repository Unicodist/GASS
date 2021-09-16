using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Http;
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
        
        public IActionResult List()
        {
            ViewBag.accountlist = dal.users.ToList();
            return View();
        }
        public IActionResult Edit(int id=-1)
        {
            if (id == -1) return RedirectToAction("List");
            ViewBag.user = dal.users.Find(id);
            return View();
        }
        public IActionResult EditAction(int id, string firstname, string lastname,string username,string email, string role)
        {
            UserModel user = dal.users.Find(id);
            user.firstname = firstname;
            user.lastname = lastname;
            user.username = username;
            user.email = email;
            user.role = role;
            dal.SaveChanges();
            return RedirectToAction("List", "Users");
        }
        public IActionResult UploadAction(AssetUploadViewModel formAsset)
        {
            return View();
        }
        public IActionResult CheckRoles(int id)
        {
            UserModel user = dal.users.SingleOrDefault(x => x.id.Equals(id));
            return Content(user.role);
        }
    }
}
