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
            if (HttpContext.Session.GetString("logged") != "true")
                return RedirectToAction("Index","Login");
            UserModel user = JsonConvert.DeserializeObject<UserModel>(HttpContext.Session.GetString("User"));
            ViewBag.user = user;
            return View();
        }
    }
}
