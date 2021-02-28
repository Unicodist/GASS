﻿using System;
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
        GASSDBContext dal = new GASSDBContext();
        public IActionResult Index()
        {
            if (IsLogged())
            {
                UserModel user = JsonConvert.DeserializeObject<UserModel>(HttpContext.Session.GetString("User"));
                ViewBag.user = user;
                return View();
            }
            ViewData["logged"] = HttpContext.Session.GetString("logged");
            return RedirectToAction("Index", "Login");
        }
        public IActionResult Staffs()
        {
            //if (GetRole().Equals("user") || !IsLogged()) return RedirectToAction("Index", "Home");
            ViewBag.adminlist = dal.users.Where(x=>x.role=="admin").Take(50).ToList();
            ViewBag.modlist = dal.users.Where(x => x.role.Equals("mod")).Take(50).ToList();
            ViewBag.userlist = dal.users.Where(x => x.role.Equals("user")).Take(50).ToList();
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
