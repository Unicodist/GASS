using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GASS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GASS.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            if (IsLogged())
            {
                UserModel user = JsonConvert.DeserializeObject<UserModel>(HttpContext.Session.GetString("User"));
                ViewBag.user = user;
                return View();
            }

            return RedirectToAction("Index", "Login");
        }
        public IActionResult Staffs()
        {
            if (GetRole().Equals("user") || !IsLogged()) return RedirectToAction("Index", "Home");
            return View();
        }
        public bool IsLogged()
        {
            return HttpContext.Session.GetString("logged") == "true";
        }
        public string GetRole()
        {
            return JsonConvert.DeserializeObject<UserModel>(HttpContext.Session.GetString("User")).role;
        }
    }
}
